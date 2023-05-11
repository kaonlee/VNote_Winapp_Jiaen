using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.DTOs;

namespace VNote.DataLayer.Interface
{
	public interface IUsersRepository
	{
		UsersDto GetByAccount (string account);
		UsersDto Get (int userId); // Edit
		void Insert (string userName,  string password);
		void Update (UsersEntity entity);
		bool Exists(string userName, string userPassword);
		bool Exists(string userName);
		int GetUserId (string userName);
	}
}
