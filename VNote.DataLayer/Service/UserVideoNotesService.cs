using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.DTOs;
using VNote.DataLayer.Infra.SqlRepository;
using VNote.DataLayer.Interface;

namespace VNote.DataLayer.Service
{
	public class UserVideoNotesService
	{
		private readonly IUserVideoNotesRepository _repo;
		private readonly IVideosRepositiry _videorepo; 
		public UserVideoNotesService(IUserVideoNotesRepository repo, IVideosRepositiry videorepo = null)
		{
			_repo = repo;
			_videorepo = videorepo;
		}

		public int Create(string videoId, int userId)
		{
			if (Exists(videoId, userId)) throw new Exception("已經有該筆筆記的紀錄");
			return _repo.Create(userId,videoId);
		}

		public void Update(UserVideoNotesEditDto dto) 
		{
			// 取得指定 noteId 的 UserVideoNotesDto 物件
			UserVideoNotesDto existingDto = Get(dto.UserVideoNoteID);
			UserVideoNotesEditDto existingEditDto = existingDto.toEditDto();
			// 比較 existingDto 和 dto 是否相等
			if (existingEditDto.IsFavorite == dto.IsFavorite
	   && existingEditDto.IsNoteLater == dto.IsNoteLater
	   && existingEditDto.Note == dto.Note
	   && existingEditDto.Tag == dto.Tag)
			{
				// 如果相等，不做任何更新
				throw new Exception("沒有更新資料，保持原樣！");
			}
			UserVideoNotesEntity entity = dto.toEntity();
			_repo.Update(entity);
		}

		public void Delete(int noteId)
		{
			_repo.Delete(noteId);
		}

		public bool Exists(string videoId, int userId)
		=> _repo.Exists(videoId, userId);

		public int GerNoteId(string videoId, int userId)
		=> _repo.GetNoteId(videoId, userId);

		public VideosDto GetVideosDto(int userVideoNoteId)
		{
			UserVideoNotesDto dto = _repo.Get(userVideoNoteId);
			string videoId = dto.VideoId;
			VideosService videosService = new VideosService(_videorepo);
			return videosService.Get(videoId);
		}

		public UserVideoNotesDto Get (int userVideoNoteId)
		=>_repo.Get(userVideoNoteId);

		public List<UserVideoNotesDto> Serarch(UserVideoNoteSearchCriteria criteria)
		=> _repo.Search(criteria);
	}
}
