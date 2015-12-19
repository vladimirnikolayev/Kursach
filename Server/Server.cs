using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
	class Server
	{
		private List<Thread> threads;

		private string adress;
		private int port;

		internal Server(string _adress, int _port)
		{
			threads = new List<Thread>();
			adress = _adress;
			port = _port;
			Listen();
		}

		void Listen()
		{
			IPHostEntry ipHost = Dns.GetHostEntry(adress);
			IPAddress ipAddr = ipHost.AddressList[0];
			IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

			Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

			Console.WriteLine("Listening for connections");

			try
			{
				sListener.Bind(ipEndPoint);
				sListener.Listen(100);

				while (true)
				{
					Socket handler = sListener.Accept();
					var thread = new Thread(Accepter);
                    threads.Add(thread);
					thread.Start(handler);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				Console.ReadLine();
			}
		}

		public static void Accepter(object _handler)
		{
			var handler = _handler as Socket;
			string data = null;

			byte[] bytes = new byte[1024];
			int bytesRec = handler.Receive(bytes);

			data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

			try
			{
				string[] timeStrings = data.Split(':');

				int expectedSeconds;
				int expectedMinutes;
				int expectedHours;
				int expectedDays;
				lock (Program.time)
				{
					expectedSeconds =
						Program.time.Seconds +
						System.Convert.ToInt32(timeStrings[2]);

					expectedMinutes =
						Program.time.Minutes +
						System.Convert.ToInt32(timeStrings[1]);
					if (expectedSeconds >= 60)
					{
						++expectedMinutes;
						expectedSeconds -= 60;
					}

					expectedHours =
						Program.time.Hours +
						System.Convert.ToInt32(timeStrings[0]);
					if (expectedMinutes >= 60)
					{
						++expectedHours;
						expectedMinutes -= 60;
					}

					expectedDays = Program.time.Days;
					if (expectedHours >= 24)
					{
						++expectedDays;
						expectedHours -= 24;
					}
				}
				Time expectedTime = new Time(
					expectedSeconds,
					expectedMinutes,
					expectedHours,
					expectedDays);

				Console.Write("Timer: " + data + "\n\n");

				while (true)
				{
					lock (Program.time)
					{
						if (expectedTime == Program.time)
							break;
					}
				}

				Console.WriteLine("end");

				byte[] msg = Encoding.UTF8.GetBytes("End: " + data);
				handler.Send(msg);
			}
			catch(Exception _e)
			{
				Console.WriteLine(_e.Message);
				handler.Send(Encoding.UTF8.GetBytes(_e.Message));
			}

			handler.Shutdown(SocketShutdown.Both);
			handler.Close();
		}

	}
}
