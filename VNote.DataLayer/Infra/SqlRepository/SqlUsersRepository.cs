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
	public class SqlUsersRepository : IUsersRepository
	{

		public bool Exists(string userName, string userPassword)
		{
			string sql = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password";
			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@UserName", 50, userName)
				.AddNvarchar("@Password", 50, userPassword)
				.Build();

			int count = SqlDb.SqlDb.ExecuteScalar<int>(SqlDb.SqlDb.GetSqlConnection, sql, parameters);
			return count > 0;
		}


		public bool Exists(string userName)
		{
			string sql = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName ";
			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@UserName", 50, userName)
				.Build();

			int count = SqlDb.SqlDb.ExecuteScalar<int>(SqlDb.SqlDb.GetSqlConnection, sql, parameters);
			return count > 0;
		}

		public UsersDto Get(int userId)
		{
			string sql = "SELECT * FROM Users WHERE UserId = @UserId";
			var parameters = SqlParameterBuilder.Create().AddInt("@UserId", userId).Build();

			Func<SqlDataReader, UsersDto> funcAssembler = reader =>
			{
				return new UsersDto
				{
					UserId = reader.GetInt32("UserId",0),
					UserName = reader.GetString("Username"),
					Password = reader.GetString("Password")
				};
			};

			return SqlDb.SqlDb.Get(SqlDb.SqlDb.GetSqlConnection, funcAssembler, sql, parameters);
		}

		public UsersDto GetByAccount(string account)
		{
			string sql = "SELECT * FROM Users WHERE Username = @Username";
			var parameters = SqlParameterBuilder.Create().AddNvarchar("@Username", 50, account).Build();

			Func<SqlDataReader, UsersDto> funcAssembler = reader =>
			{
				return new UsersDto
				{
					UserId = reader.GetInt32("UserId",0),
					UserName = reader.GetString("Username"),
					Password = reader.GetString("Password")
				};
			};

			return SqlDb.SqlDb.Get(SqlDb.SqlDb.GetSqlConnection, funcAssembler, sql, parameters);
		}

		public void Insert(string userName, string password)
		{
			string sql = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@Username", 50, userName)
				.AddNvarchar("@Password", 50, password)
				.Build();

			SqlDb.SqlDb.InsertAndReturnId(SqlDb.SqlDb.GetSqlConnection, sql, parameters);
		}

		public void Update(UsersEntity entity)
		{
			string sql = "UPDATE Users SET UserName = @UserName, Password = @Password WHERE UserId = @UserId";
			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@UserName", 50, entity.UserName)
				.AddNvarchar("@Password", 50, entity.Password)
				.AddInt("@UserId", entity.UserId)
				.Build();

			SqlDb.SqlDb.UpdateOrDelete(SqlDb.SqlDb.GetSqlConnection, sql, parameters);
		}

		public int GetUserId(string userName)
		{
			string sql = "SELECT UserId FROM Users WHERE UserName = @UserName";
			var parameters = SqlParameterBuilder.Create().AddNvarchar("@UserName", 50, userName).Build();

			int userId = SqlDb.SqlDb.ExecuteScalar<int>(SqlDb.SqlDb.GetSqlConnection, sql, parameters);
			return userId;
		}


	}

}
