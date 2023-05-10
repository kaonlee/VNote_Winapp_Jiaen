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
		UserVideoNotesDto Get(string userVideoNoteId);
		List<UserVideoNotesDto> Search(UserVideoNoteSearchCriteria searchCriteria);
		bool Exists(string videoId, int userId);
	}
	public class UserVideoNoteSearchCriteria
	{
		public string Keyword { get; set; }
		public string VideoTitle { get; set; }
		public string VideoId { get; set; }
		public int? UserId { get; set; }
		public bool? IsFavorite { get; set; }
		public bool? IsNoteLatter { get; set; }
	
	}
}
