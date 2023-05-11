using Google.Apis.YouTube.v3.Data;
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
		public string VideoTitle { get; set; }
		public string ThumbnailUrl { get; set; }
		public DateTime? LiveStartedAt { get; set; }
		public string FormattedDuration { get; set; }
        public string ChannelName { get; set; }
        //public int SlicesCountter { get; set; }
    }

	public static class UserVideoNotesDtoExtensions
	{
		public static UserVideoNotesEditDto toEditDto (this UserVideoNotesDto dto)
		{
			return new UserVideoNotesEditDto
			{
				UserVideoNoteID = dto.UserVideoNoteId,
				IsFavorite = dto.IsFavorite,
				IsNoteLater = dto.IsNoteLater,
				VideoId = dto.VideoId,
				LastEditAt = (DateTime?)dto.LastEditAt,
				Note = dto.Note ?? string.Empty,
				Tag = dto.Tag ?? string.Empty
			};
		}

	}

}
