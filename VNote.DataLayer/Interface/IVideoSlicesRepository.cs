using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.DTOs;

namespace VNote.DataLayer.Interface
{
	public interface IVideoSlicesRepository
	{
		void Create(VideoSlicesEntity entity);
		void Update(VideoSlicesEntity entity);
		void Delete(string videoId);
		VideoSlicesDto Get(string videoId);
		List<VideoSlicesDto> Search(VideoSlicesSearchCriteria searchCriteria);
	}
	public class VideoSlicesSearchCriteria
	{
		public string Keyword { get; set; }
		public string VideoTitle { get; set; }
		public string ChannelTitle { get; set; }
		public DateTime? PublishedAfter { get; set; }
		public DateTime? PublishedBefore { get; set; }
		public int? DurationSeconds { get; set; }
	}
}
