using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.DTOs;
using VNote.DataLayer.Interface;

namespace VNote.DataLayer.Service
{
	public class UserVideoNotesService
	{
		private readonly IUserVideoNotesRepository _repo;
		public UserVideoNotesService(IUserVideoNotesRepository repo)
		{
			_repo = repo;
		}

		public int Create(string videoId, int userId)
		{
			if (Exists(videoId, userId)) throw new Exception("已經有該筆筆記的紀錄");
			return _repo.Create(userId,videoId);
		}

		public void Update( UserVideoNotesEditDto dto) 
		{
			UserVideoNotesEntity entity = dto.toEntity();
			_repo.Update(entity);
		}

		public bool Exists(string videoId, int userId)
		=> _repo.Exists(videoId, userId);
	}
}
