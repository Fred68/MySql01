using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;				// DataTable

namespace MySql01
	{
	class connessione
		{
		public enum TipoComando { NonQuery, Scalar, Query };

		private MySqlConnection conn;
		public MySqlConnection conness
			{
			get { return conn;}
			}
		private string server;
		private string database;
		private string uid;
		private string password;
		private string connectionString;

		private DataTable schema;

		protected Queue<string> comandi;

		public connessione(string srv, string db, string user, string pwd)			// Costruttore
			{
			Inizializza(srv, db, user, pwd);
			}
		void Inizializza(string srv, string db, string user, string pwd)			// Inizializza
			{
			server = srv;
			database = db;
			uid = user;
			password = pwd;
			connectionString = string.Format(Properties.Resources.STRconnessione, srv, db, user, pwd);
			//MessageBox.Show(connectionString, "Connessione con stringa:");
			comandi = new Queue<string>();
			try
				{
				conn = new MySqlConnection();
				}
			catch
				{
				MessageBox.Show("Fallita creazione della connessione");
				}
			}
		public bool ApriConnessione()												// Apre connessione
			{
			try
				{
				conn.ConnectionString = connectionString;
				conn.Open();
				MessageBox.Show(String.Format("Versione MySQL: {0}\nStato: {3}\nDatabase: {1}\nStringa: {2}", conn.ServerVersion,conn.Database,conn.ConnectionString,conn.State.ToString()));
				return true;
				}
			catch(MySqlException ex)
				{
				MessageBox.Show("MySqlException " + ex.Number.ToString() + ":\n" + ex.Message);
				return false;
				}
			}
		public bool ChiudiConnessione()												// Chiude connessione
			{
			bool ret = false;
			try
				{
				conn.Close();
				MessageBox.Show("\nConnessione: " + conn.State.ToString());					// Rimane connessa in sleep
				MySqlConnection.ClearPool(conn);											// Chiude la connessione in attesa											
				ret = true;
				conn.Dispose();
				conn = null;
				}
			catch(MySqlException exSql)
				{
				MessageBox.Show("\nMySqlException: " + exSql.Number.ToString() + ": " + exSql.Message);
				}
			catch(Exception ex)
				{
				MessageBox.Show("\nEccezione:" + ex.ToString() );
				}
			return ret;
			}
		public string VerificaConnessione()											// Verifica stato connessione
			{
			string st = "";
			try
				{
				st = conn.State.ToString() + '\n'+
				conn.Database.ToString() + '\n'+
				conn.ConnectionString;
				}
			catch(MySqlException ex)
				{
				MessageBox.Show("MySqlException " + ex.Number.ToString() + ": " + ex.Message);
				}
			catch(Exception ex)
				{
				MessageBox.Show("\nEccezione:" + ex.ToString());
				}
			return st;
			}
		public void LeggiSchema()													
			{
			if(conn == null)
				return;
			try
				{
				schema = conn.GetSchema("Databases"); // Tables, MetaDataCollections...
				}
			catch(MySqlException ex)
				{
				MessageBox.Show("MySqlException " + ex.Number.ToString() + ": " + ex.Message);
				}
			MessageScrollBox mssb = new MessageScrollBox();
			mssb.SetText(FormattaSchema(schema));
			mssb.Show();
			}
		protected string FormattaSchema(DataTable dt)								
			{
			StringBuilder str = new StringBuilder();
			foreach(System.Data.DataRow row in dt.Rows)
				{
				foreach(System.Data.DataColumn col in dt.Columns)
					{
					str.Append(String.Format("{0} = {1}\n", col.ColumnName, row[col]));
					}
				str.Append("============================\n");
				}
			return str.ToString();
			}
		public bool EseguiScalare(string cmd, out string response)					// Esegue comando Scalare (una risposta)
			{
			bool ret = false;
			response = "";
			try
				{
				MySqlCommand command = new MySqlCommand(cmd, conn);
				response = Convert.ToString(command.ExecuteScalar());
				ret = true;
				}
			catch(Exception ex)
				{
				MessageBox.Show("Exception: " + ex.Message);
				}
			return ret;
			}
		public bool EseguiNonQuery(string cmd)										// Esegue comando non query (nessuna risposta)
			{
			bool ret = false;
			try
				{
				MySqlCommand command = new MySqlCommand(cmd, conn);
				command.ExecuteNonQuery();
				ret = true;
				}
			catch(Exception ex)
				{
				MessageBox.Show("Exception: " + ex.Message);
				}
			return ret;
			}
		public int AccodaComando(string cmd)										// Accoda un comando
			{
			comandi.Enqueue(cmd);
			return comandi.Count;
			}
		public int SvuotaComandi()													// Elimina tutti i comandi
			{
			int x = comandi.Count;
			comandi.Clear();
			return x;
			}
		public bool EseguiComandi(TipoComando tipo, out string risposta, bool svuota_se_err = true)		// Esegue la coda di comandi
			{
			StringBuilder strbRisposta = new StringBuilder();
			bool ok = true;
			string tmpCmd = "";			
			string tmpRsp;
			while(comandi.Count>0)
				{
				tmpCmd = comandi.Dequeue();
				bool bCmd;
				switch(tipo)
					{
					case TipoComando.Scalar:
						{
						bCmd = EseguiScalare(tmpCmd, out tmpRsp);
						}
						break;
					case TipoComando.NonQuery:
						{
						bCmd = EseguiNonQuery(tmpCmd);
						tmpRsp = "";
						}
						break;
					default:
						{
						bCmd = false;
						tmpRsp = "";
						}
						break;
					}
				if(bCmd)
					{
					if(tmpRsp.Length>0)
						{
						strbRisposta.Append(tmpRsp);
						strbRisposta.Append('\n');
						}
					}
				else
					{
					ok = false;
					if(svuota_se_err)
						comandi.Clear();
					}

				}
			risposta = strbRisposta.ToString();
			return ok;
			}
		public bool EseguiComandi(TipoComando tipo, bool svuota_se_err = true)		// Esegue la coda dei comandi solo se NonQuery
			{
			string tmp;
			if(tipo == TipoComando.NonQuery)
				return EseguiComandi(tipo, out tmp, svuota_se_err);
			else
				return false;
			}
		public bool EseguiComandi(bool svuota_se_err = true)						// Esegue la coda dei comandi come NonQuery
			{
			return EseguiComandi(TipoComando.NonQuery, svuota_se_err);
			}
		public bool EseguiTransazione()												// Esegue i comandi come transazione di NonQuery
			{
			bool ok = true;
			string msg = "";
			MySqlTransaction tr = null;
			try
				{
				tr = conn.BeginTransaction();
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = conn;
				cmd.Transaction = tr;
				while(comandi.Count > 0)
					{
					cmd.CommandText = comandi.Dequeue();
					cmd.ExecuteNonQuery();
					}
				tr.Commit();
				msg += "Transazione completata";
				}
			catch(MySqlException exSql)
				{
				msg += "\nErrore: " + exSql.ToString() + ": annullamento transazione.";
				try
					{
					tr.Rollback();
					msg += "\nTransazione annullata.";
					}
				catch(Exception exR)
					{
					msg += "\nErrore: " + exR.ToString() + ": fallito rollback !";
					}
				}
			catch(Exception ex)
				{
				msg += "\nErrore";
				if(conn==null)	msg += "Connessione chiusa";
				}
			if(msg.Length>0)
				MessageBox.Show(msg);
			return ok;
			}
		}	// Connessione
	}	// namespace


// ATTENZIONE: LA CONNESSIONE PUO` ESSERE CHIUSA
// OPPURE PUÒ ESSERE NULLA -> Exception, non MySqlException...