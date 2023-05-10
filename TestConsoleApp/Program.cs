// See https://aka.ms/new-console-template for more information
using TestClassLib;
using System.Security.Permissions;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("Hello, World!");

YouTubeAPIHelper youtubeHelper = new YouTubeAPIHelper("AIzaSyATjyd6HONNdL3ehIlYT8YGAYT_Vje6EgA");
try
{

string channelurl = "https://www.youtube.com/@IkeEveland";
DateTime afterat = DateTime.Parse("2023-04-01");
DateTime beforat = DateTime.Parse("2023-05-03");
List<YouTubeVideo> videolist = youtubeHelper.GetChannelList(channelurl, afterat, beforat).Result;

	foreach (YouTubeVideo video in videolist)
	{
		Console.WriteLine(video.ThumbnailUrl);
	}
}catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}


try
{
	string url = "https://www.youtube.com/watch?v=7moKJju3oUE";

	YouTubeVideo video = youtubeHelper.GetVideoDetail(url).Result;
	Console.WriteLine(video.VideoTitle);
	Console.WriteLine(video.VideoId);
	Console.WriteLine(video.LiveStartedAt);
	Console.WriteLine(video.PublishedAt);
	Console.WriteLine(video.IsStreamVideo);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}




//try
//{
//	string url = "https://www.youtube.com/watch?v=96dkyfPFwKU";

//	YouTubeVideo video = youtubeHelper.GetVideoDetail(url).Result;
//	Console.WriteLine(video.Title);
//	Console.WriteLine(video.LiveStartedAt);
//	Console.WriteLine(video.PublishedAt);
//	Console.WriteLine(video.IsStreamVideo);
//}
//catch (Exception ex)
//{
//	Console.WriteLine(ex.Message);
//}