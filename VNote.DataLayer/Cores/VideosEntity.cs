using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.Cores
{
	public class VideosEntity
	{
		public string VideoId { get; private set; }
		public string VideoTitle { get; private set; }
		public string ThumbnailUrl { get; private set; }
		public string ChannelId { get; private set; }
		public string ChannelTitle { get; private set; }
		public bool IsStreamVideo { get; private set; }
		public DateTime? LiveStartedAt { get; private set; }
		public DateTime? PublishedAt { get; private set; }
		public int DurationSecond { get; private set; }
        public VideosEntity(string videoId, string videoTitle, string thumbnailUrl, string channelId, string channelTitle, bool isStreamVideo, DateTime? liveStartedAt, DateTime? publishedAt, int durationSecond)
		{
            this.VideoId = videoId;
			this.VideoTitle = videoTitle;
			this.ThumbnailUrl = thumbnailUrl;
			this.ChannelId = channelId;
			this.ChannelTitle = channelTitle;
			this.IsStreamVideo = isStreamVideo;
			this.LiveStartedAt = liveStartedAt;
			this.PublishedAt = publishedAt;
			this.DurationSecond = durationSecond;
        }
    }

}
