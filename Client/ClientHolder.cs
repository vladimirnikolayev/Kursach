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
		private List<Thread> threads;

		public ClientHolder ()
		{
			threads = new List<Thread>();
        }

		public void addTimer (string _time)
		{
			//TODO
			try
			{
				var thread = new Thread(Timer);
				threads.Add(thread);
				thread.Start(_time);
			}
			finally
			{
				MessageBox.Show("Cant connect to server", "ConnectionError");
			}
		}

		void Timer (object _time)
		{

			IPHostEntry ipHost = Dns.GetHostEntry("localhost");
			IPAddress ipAddr = ipHost.AddressList[0];
			IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

			Socket _sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

			if (_sender.Available == 0)
				return;

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

	}
}
