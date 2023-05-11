using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;

namespace VNote.DataLayer.DTOs
{
	public class UsersDto
	{
		public int UserId { get;  set; }
		public string UserName { get;  set; }
		public string Password { get;  set; }
	}

	public static class UserDtoExtensions
	{
		public static UsersEntity toEntity(this UsersDto dto)
		=> new UsersEntity(dto.UserId, dto.UserName, dto.Password);
	}
}
