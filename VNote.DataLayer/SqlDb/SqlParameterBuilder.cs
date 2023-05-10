using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.SqlDb
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter> _paramerter = new List<SqlParameter> { };

		public static SqlParameterBuilder Create()
			=> new SqlParameterBuilder();

		public SqlParameterBuilder AddInt(string name, int? value)
		{
			var parameter = new SqlParameter(name, SqlDbType.Int) { Value = value };
			_paramerter.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddBit(string name, bool value)
		{
			var parameter = new SqlParameter(name, SqlDbType.Bit) { Value = value };
			_paramerter.Add(parameter);

			return this;
		}

		//public SqlParameterBuilder AddIntNullable(string name, int value)


		public SqlParameterBuilder AddNvarchar(string name, int length, string value)
		{
			var parameter = string.IsNullOrEmpty(value)
				? new SqlParameter(name, SqlDbType.NVarChar, length) { Value = DBNull.Value }
				: new SqlParameter(name, SqlDbType.NVarChar, length) { Value = value };
			_paramerter.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddVarchar(string name, int length, string value)
		{
			var parameter = string.IsNullOrEmpty(value)
				? new SqlParameter(name, SqlDbType.VarChar, length) { Value = DBNull.Value }
				: new SqlParameter(name, SqlDbType.VarChar, length) { Value = value };
			_paramerter.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddOutPutInt(string name)
		{
			var parameter = new SqlParameter(name, SqlDbType.Int) { Direction = ParameterDirection.Output };
			_paramerter.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddDateTime(string name, DateTime value)
		{
			var parameter = new SqlParameter(name, SqlDbType.DateTime) { Value = value };
			_paramerter.Add(parameter);
			return this;
		}

		public SqlParameterBuilder AddDateTimeNullable(string name, DateTime? value)
		{
			var parameter = new SqlParameter(name, SqlDbType.DateTime);
			parameter.Value = (object)value ?? DBNull.Value;
			_paramerter.Add(parameter);
			return this;
		}

		public SqlParameter[] Build()
		=> _paramerter.ToArray();

	}
}
