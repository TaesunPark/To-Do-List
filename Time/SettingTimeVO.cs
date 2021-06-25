using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectInSchool
{
	class SettingTimeVO : ITimeSettingService
	{
		private string dateTime;
		private string year;
		private string month;
		private string day;
		private string min;
		private string hour;		

		public SettingTimeVO(string dateTime,string year,string month, string day, string hour, string min)
		{
			this.dateTime = dateTime;
			this.year = year;
			this.month = month;
			this.day = day;
			this.hour = hour;
			this.min = min;						
		}

		public string GetDateTime()
		{
			return dateTime;
		}

		public string GetMin()
		{
			return min;
		}

		public string GetHour()
		{
			return hour;
		}

		

		public string GetTextInfo()
		{
			return dateTime + "," + changeNumberString(hour) + ":" + changeNumberString(min);
		}

		public string GetRemainTime()
		{			
			DateTime now = DateTime.Now;
			DateTime futureTime = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day), int.Parse(hour), int.Parse(min),0);
			TimeSpan remainTime = futureTime.Subtract(now);			

			return  remainTime.Days + "days" + ", " + changeNumberString(remainTime.Hours.ToString()) + "hour" + ":" + changeNumberString(remainTime.Minutes.ToString()) + "min" ;
		}		

		public string changeNumberString(string tmp)
		{
			if (int.Parse(tmp) >= 0 && int.Parse(tmp) <= 9)
			{
				tmp = "0" +tmp;
			}

			return tmp;
		}
	
	}
}
