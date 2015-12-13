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

		internal Server()
		{
			threads = new List<Thread>();
			Listen();
		}

		void Listen()
		{
			// Устанавливаем для сокета локальную конечную точку
			IPHostEntry ipHost = Dns.GetHostEntry("localhost");
			IPAddress ipAddr = ipHost.AddressList[0];
			IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

			// Создаем сокет Tcp/Ip
			Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

			// Назначаем сокет локальной конечной точке и слушаем входящие сокеты
			try
			{
				sListener.Bind(ipEndPoint);
				sListener.Listen(100);

				// Начинаем слушать соединения
				while (true)
				{
					Console.WriteLine("Waiting for connection {0}", ipEndPoint);

					// Программа приостанавливается, ожидая входящее соединение
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

			// Мы дождались клиента, пытающегося с нами соединиться

			byte[] bytes = new byte[1024];
			int bytesRec = handler.Receive(bytes);

			data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

			// Показываем данные на консоли
			Console.Write("Полученный текст: " + data + "\n\n");

			// Отправляем ответ клиенту\
			//string reply = "Спасибо за запрос в " + data.Length.ToString()
			//		+ " символов";
			//byte[] msg = Encoding.UTF8.GetBytes(reply);
			//handler.Send(msg);

			//if (data.IndexOf("<TheEnd>") > -1)
			//{
			//	Console.WriteLine("Сервер завершил соединение с клиентом.");
			//	break;
			//}

			handler.Shutdown(SocketShutdown.Both);
			handler.Close();
		}

	}
}
