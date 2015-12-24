using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class AddressChangerForm : Form
	{
		public string IP { set; get; }
		public int Port { set; get; }
		public bool Ok { set; get; }

		public AddressChangerForm( string _ip, int _port )
		{
			IP = _ip;
			Port = _port;
			Ok = false;
			InitializeComponent();
		}

		private void AdressChangerForm_Load(object sender, EventArgs e)
		{
			textBoxIP.Text = IP;
			textBoxPort.Text = Port.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Ok = true;

				IP = textBoxIP.Text;
				Port = System.Convert.ToInt32(textBoxPort.Text);

				Close();
			}
			catch(Exception _e)
			{
				MessageBox.Show(_e.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
