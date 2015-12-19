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
	public partial class Dialog : Form
	{
		private string m_time;
		private ClientHolder m_clientsHolder;
		private System.Media.SoundPlayer m_player;

		public Dialog( string _time, ClientHolder _cliets)
		{
			m_time = _time;
			m_clientsHolder = _cliets;
			PlaySound();

			InitializeComponent();
		}

		private void Dialog_Load(object sender, EventArgs e)
		{
			label1.Text = "End of timer: " + m_time;
		}

		private void buttonRepeat_Click(object sender, EventArgs e)
		{
			m_clientsHolder.addTimer(m_time);
			CloseForm();
		}

		private void buttonOneMinute_Click(object sender, EventArgs e)
		{
			m_clientsHolder.addTimer("00:01:00");
			CloseForm();
		}

		private void buttonEnd_Click(object sender, EventArgs e)
		{
			CloseForm();
		}

		private void CloseForm ()
		{
			m_player.Stop();
			Close();
		}

		private void PlaySound()
		{
			m_player = new System.Media.SoundPlayer( Client.Properties.Resources.Alarm01);
			m_player.Load();
			m_player.PlayLooping();
		}
	}
}
