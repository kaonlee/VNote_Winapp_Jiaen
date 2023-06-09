﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.Interface;
using System.Configuration;
using VNote.DataLayer.SqlDb;
using System.Data.SqlClient;
using VNote.DataLayer.DTOs;

namespace VNote.DataLayer.Infra.SqlRepository
{
	public class SqlVideosRepository : IVideosRepositiry
	{
		public void Create(VideosEntity entity)
		{
			string sql = "INSERT INTO Videos (VideoId, VideoTitle, ThumbnailUrl, ChannelID, ChannelName, IsStreamVideo, LiveStartedAt, PublishedAt, DurationSecond) " +
			 "VALUES (@VideoId, @VideoTitle, @ThumbnailUrl, @ChannelID, @ChannelName, @IsStreamVideo, @LiveStartedAt, @PublishedAt, @DurationSecond)";
			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@VideoId", 100, entity.VideoId)
				.AddNvarchar("@VideoTitle", 200, entity.VideoTitle)
				.AddVarchar("@ThumbnailUrl", 200, entity.ThumbnailUrl)
				.AddNvarchar("@ChannelID", 100, entity.ChannelId)
				.AddNvarchar("@ChannelName", 100, entity.ChannelTitle)
				.AddBit("@IsStreamVideo", entity.IsStreamVideo)
				.AddDateTimeNullable("@LiveStartedAt", entity.LiveStartedAt)
				.AddDateTimeNullable("@PublishedAt", entity.PublishedAt)
				.AddInt("@DurationSecond", entity.DurationSecond)
				.Build();

			SqlDb.SqlDb.InsertWithSpecifiedId(SqlDb.SqlDb.GetSqlConnection, sql, parameters);

		}

		public void Delete(string videoId)
		{
			throw new NotImplementedException();
		}

		public bool Exists(string videoId)
		{
			string sql = $"SELECT COUNT(*) FROM videos WHERE videoId = '{videoId}'";
			int count = SqlDb.SqlDb.ExecuteScalar<int>(SqlDb.SqlDb.GetSqlConnection, sql);
			return count > 0;
		}

		public VideosEntity Get(string videoId)
		{
			string sql = $"select * from Videos where VideoId = '{videoId}'";

			Func<SqlDataReader, VideosEntity> funcAssembler =
				reader =>
				{
					string videoTitle = reader.GetString("VideoTitle");
					string thumbnailUrl = reader.GetString("ThumbnailUrl");
					string channelId = reader.GetString("ChannelID");
					string channelTitle = reader.GetString("ChannelName");
					bool isStreamVideo = (bool)reader.GetBool("IsStreamVideo");
					DateTime? liveStartedAt = reader.GetDateTime("LiveStartedAt",DateTime.MinValue);
					DateTime? publishedAt = reader.GetDateTime("PublishedAt",DateTime.MinValue);
					int durationSecond = reader.GetInt32("DurationSecond",0);
					return new VideosEntity(videoId, videoTitle, thumbnailUrl, channelId, channelTitle, isStreamVideo, liveStartedAt, publishedAt, durationSecond);
				};

			return SqlDb.SqlDb.Get<VideosEntity>(SqlDb.SqlDb.GetSqlConnection, funcAssembler, sql);
		}

		public List<VideosEntity> Search(VideoSearchCriteria searchCriteria)
		{
			throw new NotImplementedException();
		}

		public void Update(VideosEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}