using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.Service.Tools;

namespace VNote.DataLayer.DTOs
{
	public class VideosDto
	{
		private static ParseTools _tools = new ParseTools();

		public string VideoId { get;  set; }
		public string VideoTitle { get;  set; }
		public string ThumbnailUrl { get;  set; }
		public string ChannelId { get;  set; }
		public string ChannelName { get;  set; }
		public bool IsStreamVideo { get;  set; }
		public DateTime? LiveStartedAt { get;  set; }
		public DateTime? PublishedAt { get;  set; }
		public int DurationSecond { get;  set; }
		public string DurationFormated 
		{ 
			get { return _tools.DurationSecondtoFormattedDuration(DurationSecond); }
		}
	}

	public static class VideosDtoExtentions
	{
		public static VideosEntity toEntity(this VideosDto dto)
		{
			return new VideosEntity(dto.VideoId, dto.VideoTitle, dto.ThumbnailUrl, dto.ChannelId, dto.ChannelName, dto.IsStreamVideo, dto.LiveStartedAt, dto.PublishedAt, dto.DurationSecond);
		}
	}
}
