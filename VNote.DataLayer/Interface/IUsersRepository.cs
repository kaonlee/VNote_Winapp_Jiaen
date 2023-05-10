using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.Interface
{
	public interface IUsersRepository
	{
		User GetByAccount (string account);
		User Get (int userId); // Edit
		void Insert (string userName,  string password);
	}
	public class User
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
