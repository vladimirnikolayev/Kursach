using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
	public class Program
	{
		internal static Time time;
		private static Timer timer;
		private static Server server;

		static void Main(string[] args)
		{
			Console.WriteLine("Ender adress");
			var adress = Console.ReadLine();
			if (adress.Length == 0)
				adress = "localhost";

			Console.WriteLine("Enter port");
			var port = Console.ReadLine();
			if (port.Length == 0)
				port = "11000";

			time = new Time();
			timer = new Timer();
			server = new Server(adress, System.Convert.ToInt32(port));
		}
	}
}
