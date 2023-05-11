using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.DTOs;

namespace VNote.DataLayer.Interface
{
	public interface IUserVideoNotesRepository
	{

		int Create(int userId, string videoId);
		void Update(UserVideoNotesEntity entity);
		void Delete(int userVideoNoteId);
		UserVideoNotesDto Get(int userVideoNoteId);
		List<UserVideoNotesDto> Search(UserVideoNoteSearchCriteria searchCriteria);
		bool Exists(string videoId, int userId);
		int GetNoteId (string videoId, int userId);

	}
	public class UserVideoNoteSearchCriteria
	{
		public int UserId { get; set; }
		public string Keyword { get; set; }
		public string Tag { get; set; }
		public bool? IsFavorite { get; set; }
		public bool? IsNoteLater { get; set; }
	
	}
}
