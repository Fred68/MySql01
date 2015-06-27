namespace MySql01
	{
	partial class Form1
		{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
			{
			if(disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
			{
			this.butApriConnessione = new System.Windows.Forms.Button();
			this.butChiudiConnessione = new System.Windows.Forms.Button();
			this.butStatoConnessione = new System.Windows.Forms.Button();
			this.parametriConnessione = new System.Windows.Forms.Button();
			this.butApriConnAdmin = new System.Windows.Forms.Button();
			this.butCreaTabNomi = new System.Windows.Forms.Button();
			this.butSchema = new System.Windows.Forms.Button();
			this.butVediNomi = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// butApriConnessione
			// 
			this.butApriConnessione.Location = new System.Drawing.Point(12, 54);
			this.butApriConnessione.Name = "butApriConnessione";
			this.butApriConnessione.Size = new System.Drawing.Size(114, 53);
			this.butApriConnessione.TabIndex = 0;
			this.butApriConnessione.Text = "Apri Connessione standard";
			this.butApriConnessione.UseVisualStyleBackColor = true;
			this.butApriConnessione.Click += new System.EventHandler(this.butApriConnessione_Click);
			// 
			// butChiudiConnessione
			// 
			this.butChiudiConnessione.Location = new System.Drawing.Point(12, 113);
			this.butChiudiConnessione.Name = "butChiudiConnessione";
			this.butChiudiConnessione.Size = new System.Drawing.Size(234, 33);
			this.butChiudiConnessione.TabIndex = 1;
			this.butChiudiConnessione.Text = "Chiudi Connessione";
			this.butChiudiConnessione.UseVisualStyleBackColor = true;
			this.butChiudiConnessione.Click += new System.EventHandler(this.butChiudiConnessione_Click);
			// 
			// butStatoConnessione
			// 
			this.butStatoConnessione.Location = new System.Drawing.Point(12, 152);
			this.butStatoConnessione.Name = "butStatoConnessione";
			this.butStatoConnessione.Size = new System.Drawing.Size(234, 33);
			this.butStatoConnessione.TabIndex = 2;
			this.butStatoConnessione.Text = "Stato Connessione";
			this.butStatoConnessione.UseVisualStyleBackColor = true;
			this.butStatoConnessione.Click += new System.EventHandler(this.butStatoConnessione_Click);
			// 
			// parametriConnessione
			// 
			this.parametriConnessione.Location = new System.Drawing.Point(12, 15);
			this.parametriConnessione.Name = "parametriConnessione";
			this.parametriConnessione.Size = new System.Drawing.Size(234, 33);
			this.parametriConnessione.TabIndex = 3;
			this.parametriConnessione.Text = "Parametri di connessione";
			this.parametriConnessione.UseVisualStyleBackColor = true;
			this.parametriConnessione.Click += new System.EventHandler(this.parametriConnessione_Click);
			// 
			// butApriConnAdmin
			// 
			this.butApriConnAdmin.Location = new System.Drawing.Point(132, 54);
			this.butApriConnAdmin.Name = "butApriConnAdmin";
			this.butApriConnAdmin.Size = new System.Drawing.Size(114, 53);
			this.butApriConnAdmin.TabIndex = 4;
			this.butApriConnAdmin.Text = "Apri Connessione Admin";
			this.butApriConnAdmin.UseVisualStyleBackColor = true;
			this.butApriConnAdmin.Click += new System.EventHandler(this.butApriConnAdmin_Click);
			// 
			// butCreaTabNomi
			// 
			this.butCreaTabNomi.Location = new System.Drawing.Point(12, 239);
			this.butCreaTabNomi.Name = "butCreaTabNomi";
			this.butCreaTabNomi.Size = new System.Drawing.Size(137, 53);
			this.butCreaTabNomi.TabIndex = 5;
			this.butCreaTabNomi.Text = "Crea tabella Nomi";
			this.butCreaTabNomi.UseVisualStyleBackColor = true;
			this.butCreaTabNomi.Click += new System.EventHandler(this.butCreaTabNomi_Click);
			// 
			// butSchema
			// 
			this.butSchema.Location = new System.Drawing.Point(12, 200);
			this.butSchema.Name = "butSchema";
			this.butSchema.Size = new System.Drawing.Size(137, 33);
			this.butSchema.TabIndex = 6;
			this.butSchema.Text = "Schema";
			this.butSchema.UseVisualStyleBackColor = true;
			this.butSchema.Click += new System.EventHandler(this.butSchema_Click);
			// 
			// butVediNomi
			// 
			this.butVediNomi.Location = new System.Drawing.Point(12, 298);
			this.butVediNomi.Name = "butVediNomi";
			this.butVediNomi.Size = new System.Drawing.Size(137, 33);
			this.butVediNomi.TabIndex = 7;
			this.butVediNomi.Text = "Vedi tabella Nomi";
			this.butVediNomi.UseVisualStyleBackColor = true;
			this.butVediNomi.Click += new System.EventHandler(this.butVediNomi_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 337);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(717, 240);
			this.dataGridView1.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(855, 589);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.butVediNomi);
			this.Controls.Add(this.butSchema);
			this.Controls.Add(this.butCreaTabNomi);
			this.Controls.Add(this.butApriConnAdmin);
			this.Controls.Add(this.parametriConnessione);
			this.Controls.Add(this.butStatoConnessione);
			this.Controls.Add(this.butChiudiConnessione);
			this.Controls.Add(this.butApriConnessione);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.Button butApriConnessione;
		private System.Windows.Forms.Button butChiudiConnessione;
		private System.Windows.Forms.Button butStatoConnessione;
		private System.Windows.Forms.Button parametriConnessione;
		private System.Windows.Forms.Button butApriConnAdmin;
		private System.Windows.Forms.Button butCreaTabNomi;
		private System.Windows.Forms.Button butSchema;
		private System.Windows.Forms.Button butVediNomi;
		private System.Windows.Forms.DataGridView dataGridView1;
		}
	}

