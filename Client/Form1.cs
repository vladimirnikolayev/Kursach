using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int seconds = textBoxSeconds.Text.Length != 0 ?
					System.Convert.ToInt32(textBoxSeconds.Text) : 0;
				int minutes = textBoxMinutes.Text.Length != 0 ?
					System.Convert.ToInt32(textBoxMinutes.Text) : 0;
				int hours = textBoxHours.Text.Length == 0 ?
					System.Convert.ToInt32(textBoxHours.Text) : 0;

				if (seconds < 0 || seconds >= 60 || minutes < 0 || minutes >= 60 || hours < 0 || hours >= 24)
					MessageBox.Show("Wrong format!");
				else
				{
					string timer = hours + ":" + minutes + ":" + seconds;
					Program.clients.addTimer(timer);
				}
			}
			catch(Exception _e)
			{
				MessageBox.Show(_e.Message);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
