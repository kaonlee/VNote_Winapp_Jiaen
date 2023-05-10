using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.Cores
{
	public class VideoSlicesEntity
	{
		public string VideoId { get; private set; }
        public string VideoSliceId { get; set; }
        public string VideoSliceTitle { get; private set; }
		public string ThumbnailUrl { get; private set; }
		public string ChannelId { get; private set; }
		public string ChannelTitle { get; private set; }
		public DateTime? PublishedAt { get; private set; }
		public int DurationSecond { get; private set; }
		public VideoSlicesEntity(string videoId, string videoTitle, string thumbnailUrl, string channelId, string channelTitle, bool isStreamVideo, DateTime? liveStartedAt, DateTime? publishedAt, int durationSecond)
		{
			this.VideoId = videoId;
			this.VideoSliceId = videoTitle;
			this.VideoSliceTitle = thumbnailUrl;
			this.ThumbnailUrl = thumbnailUrl;
			this.ChannelId = channelId;
			this.ChannelTitle = channelTitle;
			this.PublishedAt = publishedAt;
			this.DurationSecond = durationSecond;
		}
	}
}
