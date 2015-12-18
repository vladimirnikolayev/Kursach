using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
	class ClientHolder
	{
		public string Ip { set; get; }
		public int Port { set; get; }

		private List<Thread> threads;

		public ClientHolder ()
		{
			threads = new List<Thread>();

			Ip = "localhost";
			Port = 11000;
        }

		public void addTimer (string _time)
		{
			var thread = new Thread(Timer);
			threads.Add(thread);
			thread.Start(_time);
		}

		void Timer (object _time)
		{
			try
			{
				IPHostEntry ipHost = Dns.GetHostEntry(Ip);
				IPAddress ipAddr = ipHost.AddressList[0];
				IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, Port);

				Socket _sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

				//if (_sender.Available == 0)
				//	return;

				_sender.Connect(ipEndPoint);

				string message = _time as string;

				byte[] msg = Encoding.UTF8.GetBytes(message);
				int bytesSent = _sender.Send(msg);

				byte[] bytes = new byte[1024];
				int bytesRec = _sender.Receive(bytes);

				MessageBox.Show(Encoding.UTF8.GetString(bytes, 0, bytesRec), "Server answer");

				_sender.Shutdown(SocketShutdown.Both);
				_sender.Close();
			}
			catch(Exception _e)
			{
				MessageBox.Show(_e.Message);
			}
		}

	}
}
