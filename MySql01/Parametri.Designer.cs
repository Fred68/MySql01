namespace MySql01
	{
	partial class Parametri
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
			{
			if(disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.tbDatabase = new System.Windows.Forms.TextBox();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.butCancel = new System.Windows.Forms.Button();
			this.butOK = new System.Windows.Forms.Button();
			this.tbAdminPassword = new System.Windows.Forms.TextBox();
			this.tbAdmin = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 49);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 81);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Database";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 113);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "User";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(29, 145);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(27, 9);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(331, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "Connessione al server MySQL";
			// 
			// tbServer
			// 
			this.tbServer.Location = new System.Drawing.Point(105, 46);
			this.tbServer.Margin = new System.Windows.Forms.Padding(4);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(348, 22);
			this.tbServer.TabIndex = 5;
			// 
			// tbDatabase
			// 
			this.tbDatabase.Location = new System.Drawing.Point(105, 78);
			this.tbDatabase.Margin = new System.Windows.Forms.Padding(4);
			this.tbDatabase.Name = "tbDatabase";
			this.tbDatabase.Size = new System.Drawing.Size(348, 22);
			this.tbDatabase.TabIndex = 6;
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(105, 110);
			this.tbUser.Margin = new System.Windows.Forms.Padding(4);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(348, 22);
			this.tbUser.TabIndex = 7;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(105, 142);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(348, 22);
			this.tbPassword.TabIndex = 8;
			// 
			// butCancel
			// 
			this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.butCancel.Location = new System.Drawing.Point(241, 281);
			this.butCancel.Name = "butCancel";
			this.butCancel.Size = new System.Drawing.Size(103, 36);
			this.butCancel.TabIndex = 9;
			this.butCancel.Text = "Cancel";
			this.butCancel.UseVisualStyleBackColor = true;
			this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
			// 
			// butOK
			// 
			this.butOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.butOK.Location = new System.Drawing.Point(350, 281);
			this.butOK.Name = "butOK";
			this.butOK.Size = new System.Drawing.Size(103, 36);
			this.butOK.TabIndex = 10;
			this.butOK.Text = "Ok";
			this.butOK.UseVisualStyleBackColor = true;
			this.butOK.Click += new System.EventHandler(this.butOK_Click);
			// 
			// tbAdminPassword
			// 
			this.tbAdminPassword.Location = new System.Drawing.Point(105, 204);
			this.tbAdminPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbAdminPassword.Name = "tbAdminPassword";
			this.tbAdminPassword.PasswordChar = '*';
			this.tbAdminPassword.Size = new System.Drawing.Size(348, 22);
			this.tbAdminPassword.TabIndex = 14;
			// 
			// tbAdmin
			// 
			this.tbAdmin.Location = new System.Drawing.Point(105, 172);
			this.tbAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.tbAdmin.Name = "tbAdmin";
			this.tbAdmin.Size = new System.Drawing.Size(348, 22);
			this.tbAdmin.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(29, 207);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Password";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(29, 175);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "Admin";
			// 
			// Parametri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 342);
			this.Controls.Add(this.tbAdminPassword);
			this.Controls.Add(this.tbAdmin);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.butOK);
			this.Controls.Add(this.butCancel);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.tbDatabase);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Parametri";
			this.Text = "Parametri";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.TextBox tbDatabase;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button butCancel;
		private System.Windows.Forms.Button butOK;
		private System.Windows.Forms.TextBox tbAdminPassword;
		private System.Windows.Forms.TextBox tbAdmin;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		}
	}