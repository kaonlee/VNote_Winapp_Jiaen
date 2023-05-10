using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace TestClassLib
{
    public class Class1
    {
		private async void GetvideoData( )
		{

			var videoId = "88i0DX4CcNg";
			var youtubeService = new YouTubeService(new BaseClientService.Initializer()
			{
				ApiKey = "AIzaSyATjyd6HONNdL3ehIlYT8YGAYT_Vje6EgA"
			});

			var videosListRequest = youtubeService.Videos.List("snippet,contentDetails,statistics");
			videosListRequest.Id = videoId;

			var videoListResponse = await videosListRequest.ExecuteAsync();
			var video = videoListResponse.Items.FirstOrDefault();

			string title = string.Empty;
			string description = string.Empty;
			string thumbnailUrl = string.Empty;
			DateTime? publishedAt = DateTime.MinValue;
			string channelId = string.Empty;

			if (video != null)
			{
				title = video.Snippet.Title;
				description = video.Snippet.Description;
				thumbnailUrl = video.Snippet.Thumbnails.Default__.Url;
				publishedAt = video.Snippet.PublishedAt;
				channelId = video.Snippet.ChannelId;
				// Use the retrieved information as needed
			}
		}

		private async void GetLiverData()
		{
			var channelUrl = "https://www.youtube.com/@IkeEveland/";
			var youtubeService = new YouTubeService(new BaseClientService.Initializer()
			{
				ApiKey = "AIzaSyATjyd6HONNdL3ehIlYT8YGAYT_Vje6EgA",
			});

			var searchListRequest = youtubeService.Search.List("snippet");
			searchListRequest.Type = "channel";
			searchListRequest.Q = channelUrl;

			var searchListResponse = await searchListRequest.ExecuteAsync();
			var channel = searchListResponse.Items.FirstOrDefault();

			string channelName = string.Empty;
			string channelId = string.Empty;

			if (channel != null)
			{
				channelName = channel.Snippet.ChannelTitle;
				channelId = channel.Id.ChannelId;
			}
		}

		private async void GetVideoListByLiver()
		{

			var service = new YouTubeService(new BaseClientService.Initializer
			{
				ApiKey = "AIzaSyATjyd6HONNdL3ehIlYT8YGAYT_Vje6EgA",
				ApplicationName = "YOUR_APPLICATION_NAME"
			});

			DateTime startDate = DateTime.Parse("2023-04-01");
			DateTime endDate = DateTime.Parse("2023-05-08");
			var searchListRequest =
				service.Search.List("snippet");
			searchListRequest.ChannelId = "UC4yNIKGvy-YUrwYupVdLDXA";
			searchListRequest.Type = "video";
			searchListRequest.PublishedAfter = startDate.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
			searchListRequest.Order = SearchResource.ListRequest.OrderEnum.Date;
			searchListRequest.PublishedBefore = endDate.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
			searchListRequest.MaxResults = 50;

			var searchListResponse = await searchListRequest.ExecuteAsync();
			var searchResults = searchListResponse.Items.ToList();

			while (searchListResponse.NextPageToken != null)
			{
				searchListRequest.PageToken = searchListResponse.NextPageToken;
				searchListResponse = await searchListRequest.ExecuteAsync();
				searchResults.AddRange(searchListResponse.Items);
			}


			//StringBuilder sb = new StringBuilder();
			//foreach (var result in searchResults)
			//{
			//	textBox1.Text = (textBox1.Text + $"Video Id: {result.Id.VideoId}");
			//	textBox1.Text = (textBox1.Text + $"Title: {result.Snippet.Title}");
			//	textBox1.Text = (textBox1.Text + $"Description: {result.Snippet.Description}");
			//	textBox1.Text = (textBox1.Text + $"Published At: {result.Snippet.PublishedAt}");
			//	textBox1.Text = (textBox1.Text + Environment.NewLine);
			//	sb.AppendLine();
			//}
		}

	}
}
