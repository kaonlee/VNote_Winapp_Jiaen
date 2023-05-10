using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNote.DataLayer.Cores
{
	public class UserVideoNotesEntity
	{
        public int UserVideoNoteId { get; set; }
		public int UserID { get; set;}
        public DateTime? LastEditAt { get; set; }
        public string VideoId { get; set; }
		public string Note { get; set; }
		public string Tag { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsNoteLater { get; set; }

        public UserVideoNotesEntity(int userVideoNoteId, int userID, DateTime? lastEditAt, string videoId, string note, string tag)
        {
            this.UserVideoNoteId = userVideoNoteId;
			this.UserID = userID;
            this.LastEditAt = lastEditAt;
            this.VideoId = videoId;
            this.LastEditAt = lastEditAt.Value;
            this.Note = note;
            this.Tag = tag;            
        }
    }
}
