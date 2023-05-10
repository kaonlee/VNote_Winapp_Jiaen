using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.Service.Tools
{
	public class ParseTools
	{
		public string DurationSecondtoFormattedDuration(int seconds)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
			string formattedDuration = timeSpan.ToString(@"hh\:mm\:ss");
			return formattedDuration;
		}

	}
}
