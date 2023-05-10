using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.DTOs;

namespace VNote.DataLayer.Interface
{
	public interface IVideosRepositiry
	{
		void Create(VideosEntity entity);
		void Update(VideosEntity entity);
		void Delete(string videoId);
		VideosEntity Get(string videoId);
		List<VideosEntity> Search(VideoSearchCriteria searchCriteria);
		bool Exists(string videoId);
	}
	public class VideoSearchCriteria
	{
		public string Keyword { get; set; }
		public string VideoTitle { get; set; }
		public string ChannelTitle { get; set; }
		public string VideoId { get; set; }
		public DateTime? PublishedAfter { get; set; }
		public DateTime? PublishedBefore { get; set; }
		public int? DurationSeconds { get; set; }
	}	
}
