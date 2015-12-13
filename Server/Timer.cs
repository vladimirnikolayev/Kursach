using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
	class Timer
	{

		static AutoResetEvent secondsEvent;
		static AutoResetEvent minutesEvent;

		Thread secondsThread;
		Thread minutesThread;
		Thread hoursThread;

		public Timer ()
		{
			secondsEvent = new AutoResetEvent(false);
			minutesEvent = new AutoResetEvent(false);
			secondsThread = new Thread(SecondsThread);
			minutesThread = new Thread(MinutesThread);
			hoursThread = new Thread(HoursThread);
			secondsThread.Start();
			minutesThread.Start();
			hoursThread.Start();
		}

		static void SecondsThread()
		{
			while (true)
			{
				lock (Program.time)
				{
					if (++Program.time.Seconds == 60)
						secondsEvent.Set();
				}
				Thread.Sleep(1000);
			}
		}

		static void MinutesThread()
		{
			while (true)
			{
				secondsEvent.WaitOne();
				lock (Program.time)
				{
					Program.time.Seconds = 0;
					if (++Program.time.Minutes == 60)
						minutesEvent.WaitOne();
				}
			}
		}

		static void HoursThread()
		{
			while (true)
			{
				minutesEvent.WaitOne();
				lock (Program.time)
				{
					Program.time.Minutes = 0;
					if (++Program.time.Hours == 24)
					{
						++Program.time.Days;
						Program.time.Hours = 0;
					}
				}
			}
		}
	}
}
