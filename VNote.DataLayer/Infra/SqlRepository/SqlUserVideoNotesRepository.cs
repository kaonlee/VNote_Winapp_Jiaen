using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.DTOs;
using VNote.DataLayer.Interface;
using VNote.DataLayer.SqlDb;

namespace VNote.DataLayer.Infra.SqlRepository
{
	public class SqlUserVideoNotesRepository : IUserVideoNotesRepository
	{
		public int Create(int userId, string videoId)
		{
			string sql = "INSERT INTO UserVideoNotes (VideoId, LastEditAt, UserId) " +
 "VALUES (@VideoId, @LastEditAt, @UserId)";
			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@VideoId", 100, videoId)
				.AddDateTimeNullable("@LastEditAt",DateTime.Now)
				.AddInt("@UserId", userId)
				.Build(); 

			return SqlDb.SqlDb.InsertAndReturnId(SqlDb.SqlDb.GetSqlConnection, sql, parameters);
		}

		public void Delete(int userVideoNoteId)
		{
			string sql = $"Delete FROM UserVideoNotes WHERE UserVideoNoteId = {userVideoNoteId}";
			SqlDb.SqlDb.UpdateOrDelete(SqlDb.SqlDb.GetSqlConnection, sql);
		}

		public bool Exists(string videoId, int userId)
		{
			string sql = $"SELECT COUNT(*) FROM UserVideoNotes WHERE videoId = '{videoId}' AND userId = {userId}";
			int count = SqlDb.SqlDb.ExecuteScalar<int>(SqlDb.SqlDb.GetSqlConnection, sql);
			return count > 0;
		}

		public UserVideoNotesDto Get(int userVideoNoteId)
		{
			var sql = $@"
        SELECT u.UserVideoNoteId, u.UserID, u.LastEditAt, u.VideoId, u.Note, u.Tag,
               u.IsFavorite, u.IsNoteLater, v.VideoTitle, v.ThumbnailUrl, v.LiveStartedAt,
               CONVERT(varchar, DATEADD(s, v.DurationSecond, 0), 108) AS FormattedDuration
        FROM UserVideoNotes u
        JOIN Videos v ON u.VideoId = v.VideoId
        WHERE u.UserVideoNoteId = {userVideoNoteId}";
			Func<SqlDataReader, UserVideoNotesDto> funcAssembler = reader =>
			{
				return new UserVideoNotesDto
				{
					UserVideoNoteId = (int)reader.GetInt32("UserVideoNoteId"),
					UserID = (int)reader.GetInt32("UserID"),
					LastEditAt = reader.GetDateTime("LastEditAt"),
					VideoId = reader.GetString("VideoId"),
					Note = reader.GetString("Note"),
					Tag = reader.GetString("Tag"),
					IsFavorite = reader.GetBool("IsFavorite", false),
					IsNoteLater = reader.GetBool("IsNoteLater", false),
					VideoTitle = reader.GetString("VideoTitle"),
					ThumbnailUrl = reader.GetString("ThumbnailUrl"),
					LiveStartedAt = reader.GetDateTime("LiveStartedAt"),
					FormattedDuration = reader.GetString("FormattedDuration")
				};
			};
			return SqlDb.SqlDb.Get(SqlDb.SqlDb.GetSqlConnection, funcAssembler, sql);
		}

		public int GetNoteId(string videoId, int userId)
		{
			string sql = $"SELECT UserVideoNoteId FROM UserVideoNotes WHERE videoId = '{videoId}' AND userId = {userId}";
			int noteId = SqlDb.SqlDb.ExecuteScalar<int>(SqlDb.SqlDb.GetSqlConnection, sql);
			return noteId; // 如果 noteId 為 null，回傳 -1Exception();
		}

		public List<UserVideoNotesDto> Search(UserVideoNoteSearchCriteria searchCriteria)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();

			var sql = $@"
        SELECT u.UserVideoNoteId, u.UserID, u.LastEditAt, u.VideoId, u.Note, u.Tag,
               u.IsFavorite, u.IsNoteLater, v.VideoTitle, v.ThumbnailUrl, v.ChannelName, 
               v.LiveStartedAt, v.DurationSecond,
               CONVERT(varchar, DATEADD(s, v.DurationSecond, 0), 108) AS FormattedDuration
        FROM UserVideoNotes u
        JOIN Videos v ON u.VideoId = v.VideoId
        WHERE (u.UserID = {searchCriteria.UserId} OR {searchCriteria.UserId} IS NULL)";

			if (searchCriteria.IsFavorite.HasValue)
			{
				sql += $" AND u.IsFavorite = {Convert.ToInt32(searchCriteria.IsFavorite.Value)}";
			}

			if (searchCriteria.IsNoteLater.HasValue)
			{
				sql += $" AND u.IsNoteLater = {Convert.ToInt32(searchCriteria.IsNoteLater.Value)}";
			}

			if (!string.IsNullOrEmpty(searchCriteria.Tag))
			{
				sql += $" AND u.Tag LIKE N'%{searchCriteria.Tag}%' ";
			}

			if (!string.IsNullOrEmpty(searchCriteria.Keyword))
			{
				sql += $" AND (u.Note LIKE N'%{searchCriteria.Keyword}%' OR v.VideoTitle LIKE N'%{searchCriteria.Keyword}%')";
			}

			Func<SqlDataReader, UserVideoNotesDto> funcAssembler = reader =>
			{
				int userVideoNoteId = reader.GetInt32("UserVideoNoteId", 0);
				int userId = reader.GetInt32("UserID", 0);
				DateTime lastEditAt = reader.GetDateTime("LastEditAt", DateTime.MinValue);
				string videoId = reader.GetString("VideoId");
				string note = reader.GetString("Note");
				string tag = reader.GetString("Tag");
				bool isFavorite = reader.GetBool("IsFavorite") ?? false;
				bool isNoteLater = reader.GetBool("IsNoteLater") ?? false;
				string videoTitle = reader.GetString("VideoTitle");
				string thumbnailUrl = reader.GetString("ThumbnailUrl");
				string channelName = reader.GetString("ChannelName");
				DateTime liveStartedAt = reader.GetDateTime("LiveStartedAt", DateTime.MinValue);
				string formattedDuration = reader.GetString("FormattedDuration");
				return new UserVideoNotesDto()
				{
					UserVideoNoteId = userVideoNoteId,
					UserID = userId,
					LastEditAt = lastEditAt,
					VideoId = videoId,
					Note = note,
					Tag = tag,
					IsFavorite = isFavorite,
					IsNoteLater = isNoteLater,
					VideoTitle = videoTitle,
					ThumbnailUrl = thumbnailUrl,
					ChannelName = channelName,
					LiveStartedAt = liveStartedAt,
					FormattedDuration = formattedDuration
				};
			};
			return SqlDb.SqlDb.Search(SqlDb.SqlDb.GetSqlConnection, funcAssembler, sql, parameters.ToArray());

		}


		public void Update(UserVideoNotesEntity entity)
		{
			string sql = "UPDATE UserVideoNotes SET LastEditAt = @LastEditAt, Tag = @Tag, IsFavorite = @IsFavorite, IsNoteLater = @IsNoteLater, Note = @Note WHERE UserVideoNoteId = @UserVideoNoteId";
			var parameters = SqlParameterBuilder.Create()
				.AddDateTime("@LastEditAt", DateTime.Now)
				.AddNvarcharNotNull("@Tag", 100, entity.Tag)
				.AddBit("@IsFavorite", entity.IsFavorite)
				.AddBit("@IsNoteLater", entity.IsNoteLater)
				.AddNvarcharNotNull("@Note", -1, entity.Note)
				.AddInt("@UserVideoNoteId", entity.UserVideoNoteId)
				.Build();

			SqlDb.SqlDb.UpdateOrDelete(SqlDb.SqlDb.GetSqlConnection, sql, parameters);
		}
	}
}
