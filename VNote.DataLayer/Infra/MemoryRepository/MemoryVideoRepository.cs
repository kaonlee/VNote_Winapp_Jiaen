using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.Interface;


namespace VNote.DataLayer.Infra.MemoryRepository
{
	public class MemoryVideoRepository : IVideosRepositiry
	{
		private static List<VideosEntity> testVideosData = new List<VideosEntity>();
		static MemoryVideoRepository()
		{
			testVideosData.Add(new VideosEntity ("id-i", "Video 1", "https://i.ytimg.com/vi/Ivgsnq7arIY/mqdefault.jpg", "c-hannel-1", "Channel 1", false, new DateTime(2022, 1, 1,10,0,0), null, 120));
			testVideosData.Add(new VideosEntity("id-2", "Video 2", "https://example.com/thumbnail/2", "c-hannel-2", "Channel 2", true, new DateTime(2022, 2, 1, 10, 0, 0), new DateTime(2022, 2, 1, 12, 0, 0), 7200));
			testVideosData.Add(new VideosEntity("id-3", "Video 3", "https://example.com/thumbnail/3", "c-hannel-3", "Channel 3", false, new DateTime(2022, 3, 1), null, 300));
		}

		public void Create(VideosEntity entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException(nameof(entity));
			}

			testVideosData.Add(entity);
		}

		public void Delete(string videoId)
		{
			testVideosData.RemoveAll(v => v.VideoId == videoId.ToString());
		}

		public bool Exists(string videoId)
		{
			throw new NotImplementedException();
		}

		public VideosEntity Get(string videoId)
		{
			return testVideosData.FirstOrDefault(v => v.VideoId == videoId.ToString());
		}

		public List<VideosEntity> Search(VideoSearchCriteria searchCriteria)
		{
			var query = testVideosData.AsQueryable();

			if (!string.IsNullOrEmpty(searchCriteria.Keyword))
			{
				query = query.Where(v => v.VideoTitle.Contains(searchCriteria.Keyword) ||
										 v.ChannelTitle.Contains(searchCriteria.Keyword));
			}

			if (searchCriteria.PublishedAfter.HasValue)
			{
				query = query.Where(v => v.PublishedAt.HasValue &&
										 v.PublishedAt.Value >= searchCriteria.PublishedAfter.Value);
			}

			if (searchCriteria.PublishedBefore.HasValue)
			{
				query = query.Where(v => v.PublishedAt.HasValue &&
										 v.PublishedAt.Value <= searchCriteria.PublishedBefore.Value);
			}

			if (searchCriteria.DurationSeconds.HasValue)
			{
				query = query.Where(v => v.DurationSecond == searchCriteria.DurationSeconds.Value);
			}

			return query.ToList();
		}

		public void Update(VideosEntity entity)
		{
			throw new NotImplementedException();
		}
	}

}
