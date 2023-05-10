using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;

namespace VNote.DataLayer.DTOs
{
	public class UserVideoNotesDto
	{
		public int UserVideoNoteId { get; set; }
		public int UserID { get; set; }
		public DateTime? LastEditAt { get; set; }
		public string VideoId { get; set; }
		public string Note { get; set; }
		public string Tag { get; set; }
		public bool IsFavorite { get; set; }
		public bool IsNoteLater { get; set; }
		public string VideoTitle { get; private set; }
		public string ThumbnailUrl { get; private set; }
		public DateTime? LiveStartedAt { get; private set; }
		public string FormattedDuration { get; private set; }
        //public int SlicesCountter { get; set; }
    }


}
