using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace VNote.DataLayer.SqlDb
{
	public class SqlDb
	{
		public static string ApplicationName { get; set; }
		public static string GetConnectionString(string keyOfConnString)
		{
			string connStr = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString].ToString();

			if (string.IsNullOrEmpty(connStr))
			{
				throw new Exception("找不到連線字串, Key=" + keyOfConnString);
			}

			SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);

			if (string.IsNullOrEmpty(ApplicationName) == false)
			{
				sb.ApplicationName = ApplicationName;
			}

			return sb.ToString();
		}
		public static SqlConnection GetSqlConnection(string keyOfConnString)
		{
			string connStr = GetConnectionString(keyOfConnString);
			return new SqlConnection(connStr);
		}
		public static SqlConnection GetSqlConnection()
		{
			return GetSqlConnection("default");
		}
		public static int UpdateOrDelete(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)// params SqlParameter[] parameters，前面多一個 params 能讓大家可以讓自己在呼叫內組的 params 也可以吃進去
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}
					return cmd.ExecuteNonQuery();
				}
			}
		}

		/// <summary>
		/// 建立一筆新資料並且回傳新增資料的自動編號
		/// </summary>
		/// <param name="funcConn"></param>
		/// <param name="sql"></param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public static int InsertAndReturnId(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			//if (
			//	funcConn?.Target is string connectionString 
			//	&& 
			//	connectionString.Equals("default", StringComparison.OrdinalIgnoreCase)
			//	)
			//{
			//	funcConn = () => SqlDb.GetSqlConnection();
			//}

			sql += ";select Scope_Identity()"; //取得新增資料的自動編號

			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
		}

		public static void InsertWithSpecifiedId(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}

					// Execute the command to insert data into the database
					cmd.ExecuteNonQuery();
				}
			}
		}

		public static T Get<T>(Func<SqlConnection> funcConn, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}

					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					return reader.Read() ? funcAssembler(reader) : default(T);
				}
			}
		}

		public static List<T> Search<T>(Func<SqlConnection> funcConn, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
		{
			List<T> list = new List<T>();
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					while (reader.Read())
					{
						T entity = funcAssembler(reader);
						list.Add(entity);
					}
					return list;
				}
			}
		}

		public static T ExecuteScalar<T>(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
					}
					var result = cmd.ExecuteScalar();
					return result != null ? (T)Convert.ChangeType(result, typeof(T)) : default(T);
				}
			}
		}


	}
}
