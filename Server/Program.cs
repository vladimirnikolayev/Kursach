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
			time = new Time();
			timer = new Timer();
			server = new Server();
		}
	}
}
