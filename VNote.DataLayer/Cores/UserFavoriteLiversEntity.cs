using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.Cores
{
	public class UserFavoriteLiversEntity
	{
        public int UserId { get; private set; }
		public int LiverId { get; private set; }
        public UserFavoriteLiversEntity(int userid, int liverid)
        {
            this.LiverId = liverid;
            this.UserId = userid;
        }
    }
}
