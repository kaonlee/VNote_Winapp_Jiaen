using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.SqlDb
{
	public static class SqlDataReaderExtensions
	{
		public static string GetString(this SqlDataReader reader, string coulumName)
		{
			// 如果欄位名稱不存在，會引發異常

			int colIndex = reader.GetOrdinal(coulumName);
			return reader.IsDBNull(colIndex)
				? null
				: reader.GetString(colIndex);
		}

		public static int? GetInt32(this SqlDataReader reader, string columName)
		{
			int colIndet = reader.GetOrdinal(columName);
			return reader.IsDBNull(colIndet)
				? (int?)null
				: reader.GetInt32(colIndet);
		}

		public static int GetInt32(this SqlDataReader reader, string columName, int defaultValue)
		{
			int? result = reader.GetInt32(columName);
			return result.HasValue
				? result.Value
				: defaultValue;
		}
		public static bool GetBool(this SqlDataReader reader, string columName, bool defaultvalue = false)
		{
			var columnIndex = reader.GetOrdinal(columName);
			return (!reader.IsDBNull(columnIndex))
				? reader.GetBoolean(columnIndex)
				: defaultvalue;
		}
		public static bool? GetBool(this SqlDataReader reader, string columName)
		{
			var columnIndex = reader.GetOrdinal(columName);
			return (!reader.IsDBNull(columnIndex))
				? reader.GetBoolean(columnIndex)
				: (bool?)null;
		}

		public static DateTime? GetDateTime(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (DateTime?)null
				: reader.GetDateTime(colIndex);
		}

		public static DateTime GetDateTime(this SqlDataReader reader, string columnName, DateTime defaultValue)
		{
			DateTime? result = reader.GetDateTime(columnName);
			return result.HasValue ? result.Value : defaultValue;
		}
	}
}
