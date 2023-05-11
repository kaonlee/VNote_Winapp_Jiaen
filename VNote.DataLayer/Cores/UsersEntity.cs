using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.Cores
{
	public class UsersEntity
	{
        public int UserId { get; private set; }
		public string UserName { get; private set; }
		public string Password { get; private set; }
        public UsersEntity(int userId, string userName, string password)
        {
            this.UserId = userId;
            this.Password = password;
            this.UserName = userName;
        }
    }
}
