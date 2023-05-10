using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
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
			throw new NotImplementedException();
		}

		public bool Exists(string videoId, int userId)
		{
			string sql = $"SELECT COUNT(*) FROM UserVideoNotes WHERE videoId = '{videoId}' AND userId = {userId}";
			int count = SqlDb.SqlDb.ExecuteScalar<int>(SqlDb.SqlDb.GetSqlConnection, sql);
			return count > 0;
		}

		public UserVideoNotesDto Get(string userVideoNoteId)
		{
			throw new NotImplementedException();
		}

		public List<UserVideoNotesDto> Search(UserVideoNoteSearchCriteria searchCriteria)
		{
			throw new NotImplementedException();
		}

		public void Update(UserVideoNotesEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
