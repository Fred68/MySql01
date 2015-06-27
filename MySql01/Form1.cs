using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace MySql01
	{
	public partial class Form1 : Form
		{

		connessione conn;															// Connessione  

		public Form1()																// Costruttore
			{
			InitializeComponent();
			conn = null;
			}
		private void butApriConnessione_Click(object sender, EventArgs e)			// Crea e apre conneesione (utente)
			{
			conn = new connessione(	Properties.Settings.Default.Server,
									Properties.Settings.Default.Database,
									Properties.Settings.Default.User,
									Properties.Settings.Default.Password);
			conn.ApriConnessione();
			}
		private void butApriConnAdmin_Click(object sender, EventArgs e)				// Crea e apre conneesione (admin)
			{
			conn = new connessione(Properties.Settings.Default.Server,
									Properties.Settings.Default.Database,
									Properties.Settings.Default.Admin,
									Properties.Settings.Default.AdminPassword);
			conn.ApriConnessione();
			}
		private void parametriConnessione_Click(object sender, EventArgs e)			// Modifica parametri di configurazione
			{
			Parametri mb = new Parametri();
			if(mb.ShowDialog()==DialogResult.OK)
				{
				MessageBox.Show(string.Format(	Properties.Resources.STRconnessione,
												Properties.Settings.Default.Server,
												Properties.Settings.Default.Database,
												Properties.Settings.Default.User,
												Properties.Settings.Default.Password)
												+"\n\n"+
								string.Format(Properties.Resources.STRconnessione,
												Properties.Settings.Default.Server,
												Properties.Settings.Default.Database,
												Properties.Settings.Default.Admin,
												Properties.Settings.Default.AdminPassword)
												, "Stringhe di connessione");
				}
			}
		private void butChiudiConnessione_Click(object sender, EventArgs e)			// Chiude la connessione
			{																		// Resta in sleep fino a chiusura programma
			if(conn != null)
				conn.ChiudiConnessione();
			}
		private void butStatoConnessione_Click(object sender, EventArgs e)			// Visualizza lo stato della connessione
			{
			if(conn != null)
				MessageBox.Show(conn.VerificaConnessione());
			}
		private void butCreaTabNomi_Click(object sender, EventArgs e)
			{
			if(conn == null)
				return;
			conn.AccodaComando("USE prova;");
			conn.AccodaComando("DROP TABLE IF EXISTS bak;");
			conn.AccodaComando("CREATE TABLE IF NOT EXISTS nomi(a INT) ENGINE=InnoDB;");
			conn.AccodaComando("RENAME TABLE nomi TO bak;");
			conn.AccodaComando("CREATE TABLE nomi (`ID` BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Contatore', `Pos` VARCHAR(20) NULL DEFAULT '0' COMMENT 'Posizione',`Nome` VARCHAR(50) NOT NULL COMMENT 'Nome',`Data` TIME NULL DEFAULT NULL COMMENT 'Data',`Numero` INT(11) NULL DEFAULT '0' COMMENT 'Numero',INDEX `Indice` (`ID`)) ENGINE=InnoDB;");
			//conn.AccodaComando("CREATE TABL err;");
//			if(!conn.EseguiComandi())
//				MessageBox.Show("Errore");
			if(!conn.EseguiTransazione())
				MessageBox.Show("Errore...");
			}
		private void butSchema_Click(object sender, EventArgs e)
			{
			if(conn != null)
				{
				conn.AccodaComando("SELECT VERSION();");
				string msg;
				if(!conn.EseguiComandi(connessione.TipoComando.Scalar, out msg))
					MessageBox.Show("Errore");
				else
					MessageBox.Show(msg);
				conn.LeggiSchema();
				}
				
			}

		private void butVediNomi_Click(object sender, EventArgs e)
			{
			if(conn != null)
				{
				MySqlConnection cn = conn.conness;
				MySqlDataAdapter da = null;
				DataSet ds = null;
				try
					{
					ds = new DataSet();
					da = new MySqlDataAdapter("SELECT * FROM nomi", cn);
					da.Fill(ds,"nomi");
					dataGridView1.DataSource = ds.Tables["nomi"];


					int cols = ds.Tables["nomi"].Columns.Count;
					
					StringBuilder strb = new StringBuilder();
					for(int i=0; i< cols; i++)
						strb.Append(ds.Tables["nomi"].Columns[i].ColumnName + ": "  +  ds.Tables["nomi"].Columns[i].DataType.ToString() + '\n');
					MessageBox.Show(strb.ToString());
					}
				catch(MySqlException exSql)
					{
					MessageBox.Show("Eccezione " + exSql.ToString());
					}
				        
				}
			}


		// Problema: multiutente.
		// Un utente blocca i record di un progetto o un record singolo, se deve modificarlo, e lo segna subito come impegnato dall'utente (in automatico da mysql).
		// Quando salva i dati: lo sblocca
		// Controllo periodico per tutti i dati bloccati: se l'utente non è più connesso, li sblocca. Oneroso.
		// Meglio se il controllo viene richiesto da un utente qualunque.
		// Usare due thread ? Uno per la scrittura dati ed uno per la connessione dell'utente (sempre attivo), che scrive il nome in una tabella specifica.
		
		
		}
	}
