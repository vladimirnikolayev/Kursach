using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	class Time
	{
		public int Seconds { set; get; }
		public int Minutes { set; get; }
		public int Hours { set; get; }
		public int Days { set; get; }

		public Time() { }

		public Time (int _seconds, int _minutes, int _hours, int _days)
		{
			Seconds = _seconds;
			Minutes = _minutes;
			Hours = _hours;
			Days = _days;
		}

		public static bool operator== ( Time _t1, Time _t2 )
		{
			return 
				_t1.Seconds == _t2.Seconds &&
				_t1.Minutes == _t2.Minutes &&
				_t1.Hours == _t2.Hours &&
				_t1.Days == _t2.Days;
		}

		public static bool operator !=(Time _t1, Time _t2)
		{
			return
				_t1.Seconds != _t2.Seconds &&
				_t1.Minutes != _t2.Minutes &&
				_t1.Hours != _t2.Hours &&
				_t1.Days != _t2.Days;
		}
	}
}
