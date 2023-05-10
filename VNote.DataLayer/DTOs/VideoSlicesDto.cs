using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.DTOs
{
	public class VideoSlicesDto
	{
		public string VideoId { get; private set; }
		public string VideoSliceId { get; set; }
		public string VideoSliceTitle { get; private set; }
		public string ThumbnailUrl { get; private set; }
		public string ChannelId { get; private set; }
		public string ChannelTitle { get; private set; }
		public DateTime? PublishedAt { get; private set; }
		public string FormattedDuration { get; private set; }
	}
}
