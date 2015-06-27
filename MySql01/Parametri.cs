using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql01
	{
	public partial class Parametri : Form
		{
		public Parametri()
			{
			InitializeComponent();
			tbServer.Text = Properties.Settings.Default.Server;
			tbDatabase.Text = Properties.Settings.Default.Database;
			tbUser.Text = Properties.Settings.Default.User;
			tbPassword.Text = Properties.Settings.Default.Password;
			tbAdmin.Text = Properties.Settings.Default.Admin;
			tbAdminPassword.Text = Properties.Settings.Default.AdminPassword;
			}

		private void butCancel_Click(object sender, EventArgs e)
			{
			Close();
			}

		private void butOK_Click(object sender, EventArgs e)
			{
			Properties.Settings.Default.Server = tbServer.Text;
			Properties.Settings.Default.Database = tbDatabase.Text;
			Properties.Settings.Default.User = tbUser.Text;
			Properties.Settings.Default.Password = tbPassword.Text;
			Properties.Settings.Default.Admin = tbAdmin.Text;
			Properties.Settings.Default.AdminPassword = tbAdminPassword.Text;

			Properties.Settings.Default.Save();
			Close();
			}

		}
	}
