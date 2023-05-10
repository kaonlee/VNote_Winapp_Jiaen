using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using VNote.DataLayer.DTOs;

namespace VNote.DataLayer.YouTube
{

	public class YouTubeAPIHelper
	{
		private readonly YouTubeService _youTubeService;

		public YouTubeAPIHelper(string apiKey)
		{
			_youTubeService = new YouTubeService(new BaseClientService.Initializer
			{
				ApiKey = apiKey,
				ApplicationName = "VNote"
			});
		}

		public async Task<List<YouTubeVideo>> GetChannelList(string channelUrl, DateTime publishedAfter, DateTime publishedBefore)
		{
			string channelId = GetChannelIdFromUrl(channelUrl).Result;
			var videos = new List<YouTubeVideo>();

			// Call the Search.List method to get the video ids and the published times
			var searchListRequest = _youTubeService.Search.List("snippet");
			searchListRequest.ChannelId = channelId;
			searchListRequest.Type = "video";
			searchListRequest.PublishedAfter = publishedAfter.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
			searchListRequest.PublishedBefore = publishedBefore.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
			searchListRequest.Order = SearchResource.ListRequest.OrderEnum.Date;
			searchListRequest.MaxResults = 50;

			var searchListResponse = await searchListRequest.ExecuteAsync();
			var videoIds = searchListResponse.Items.Select(item => item.Id.VideoId).ToList();

			// Call the Video.List method to get the video details
			var videoListRequest = _youTubeService.Videos.List("snippet, contentDetails, liveStreamingDetails");
			videoListRequest.Id = string.Join(",", videoIds);

			var videoListResponse = await videoListRequest.ExecuteAsync();
			var videoList = videoListResponse.Items;

			foreach (var video in videoList)
			{
				var youTubeVideo = ConvertVideoToListItem(video);
				videos.Add(youTubeVideo);
			}

			return videos;
		}
		public async Task<YouTubeVideo> GetVideoDetail(string videoUrl)
		{
			var videoId = GetVideoIdFromUrl(videoUrl);
			var videoListRequest = _youTubeService.Videos.List("snippet, contentDetails, liveStreamingDetails");
			videoListRequest.Id = videoId;

			var videoListResponse = await videoListRequest.ExecuteAsync();
			var video = videoListResponse.Items.FirstOrDefault();

			if (video != null)
			{
				var youTubeVideo = ConvertVideoToListItem(video);
				return youTubeVideo;
			}

			return null;
		}

		public async Task<YouTubeChannel> GetChannelDetail(string channelUrl)
		{
			string channelId = GetChannelIdFromUrl(channelUrl).Result;

			// Call the Channels.List method to get the channel details
			var channelListRequest = _youTubeService.Channels.List("snippet");
			channelListRequest.Id = channelId;

			var channelListResponse = await channelListRequest.ExecuteAsync();
			var channel = channelListResponse.Items.FirstOrDefault();

			if (channel != null)
			{
				var youTubeChannel = new YouTubeChannel
				{
					ChannelID = channel.Id,
					ChannelName = channel.Snippet.Title,
					ChannelIcon = channel.Snippet.Thumbnails.Medium.Url
				};

				return youTubeChannel;
			}

			return null;
		}


		private string GetVideoIdFromUrl(string videoUrl)
		{
			// Extract the video ID from the video URL
			var uri = new Uri(videoUrl);
			var query = HttpUtility.ParseQueryString(uri.Query);
			var videoId = query.Get("v");
			return videoId;
		}

		private async Task<string> GetChannelIdFromUrl(string channelUrl)
		{
			// Extract the channel ID from the channel URL
			var searchListRequest = _youTubeService.Search.List("snippet");
			searchListRequest.Type = "channel";
			searchListRequest.Q = channelUrl;

			var searchListResponse = await searchListRequest.ExecuteAsync();
			var channel = searchListResponse.Items.FirstOrDefault();

			if (channel != null)
			{
				return channel.Id.ChannelId;
			}

			return null;
		}

		private YouTubeVideo ConvertVideoToListItem(Video video)
		{
			var youTubeVideo = new YouTubeVideo
			{
				VideoId = video.Id,
				VideoTitle = video.Snippet.Title,
				ThumbnailUrl = video.Snippet.Thumbnails.Medium.Url,
				ChannelId = video.Snippet.ChannelId,
				ChannelName = video.Snippet.ChannelTitle,
				IsStreamVideo = (video.Snippet.PublishedAt != null &&
				 video.Snippet.LiveBroadcastContent == "live" &&
				 (video.Snippet.PublishedAt != video.LiveStreamingDetails?.ActualStartTime || video.Snippet.PublishedAt.HasValue == false)),
				PublishedAt = video.Snippet.PublishedAt,
				LiveStartedAt = video.LiveStreamingDetails?.ActualStartTime,
				DurationSecond = (int)XmlConvert.ToTimeSpan(video.ContentDetails.Duration).TotalSeconds,
			};
			return youTubeVideo;
		}
	}

	public class YouTubeVideo
	{
		public string VideoId { get; set; }
		public string VideoTitle { get; set; }
		public string ThumbnailUrl { get; set; }
		public string ChannelId { get; set; }
		public string ChannelName { get; set; }
		public bool IsStreamVideo { get; set; }
		public DateTime? LiveStartedAt { get; set; }
		public DateTime? PublishedAt { get; set; }
		public int DurationSecond { get; set; }
	}

	public class YouTubeChannel
	{
		public string ChannelID { get; set; }
		public string ChannelName { get; set; }
		public string ChannelIcon { get; set; }
	}

	public static class YoutubeApiHelperExtentions
	{
		public static VideosDto toVideosDto (this YouTubeVideo ytvideo) 
		{
			VideosDto videosDto = new VideosDto()
			{
				VideoId = ytvideo.VideoId,
				VideoTitle = ytvideo.VideoTitle,
				ThumbnailUrl = ytvideo.ThumbnailUrl,
				ChannelId = ytvideo.ChannelId,
				ChannelName = ytvideo.ChannelName,
				DurationSecond = ytvideo.DurationSecond,
				PublishedAt = ytvideo.PublishedAt,
				LiveStartedAt = ytvideo.LiveStartedAt,
				IsStreamVideo = ytvideo.IsStreamVideo
			};
			return videosDto;
		}
	}

	public class YouTubeApiTools
	{

	}
}