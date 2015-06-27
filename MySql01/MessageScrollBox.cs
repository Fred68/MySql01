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
	public partial class MessageScrollBox : Form
		{
		public MessageScrollBox()
			{
			InitializeComponent();
			}
		public void SetText(string str)
			{
			richTextBox1.Text = str;
			}
		}
	}
