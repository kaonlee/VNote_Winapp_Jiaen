using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;

namespace VNote.DataLayer.DTOs
{
	public class UserVideoNotesEditDto
	{
		public int UserVideoNoteID { get; set; }
		public DateTime? LastEditAt { get; set; }
		public string VideoId { get; set; }
		public string Note { get; set; }
		public string Tag { get; set; }
		public bool IsFavorite { get; set; }
		public bool IsNoteLater { get; set; }
	}

	public static class UserVideoNotesEditDtoExtentions
	{
		public static UserVideoNotesEntity toEntity(this UserVideoNotesEditDto dto)
		{
			return new UserVideoNotesEntity(dto.UserVideoNoteID, dto.UserVideoNoteID, dto.LastEditAt, dto.VideoId, dto.Note, dto.Tag, dto.IsFavorite, dto.IsNoteLater);
		}

	}
}
