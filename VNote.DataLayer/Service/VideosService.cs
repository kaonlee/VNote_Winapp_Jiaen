using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using VNote.DataLayer.Cores;
using VNote.DataLayer.DTOs;
using VNote.DataLayer.Interface;

namespace VNote.DataLayer.Service
{
	public class VideosService
	{
		private readonly IVideosRepositiry _repo;
        public VideosService( IVideosRepositiry repo ) 
        {
            _repo = repo;
        }

        public void Create (VideosDto dto)
        {
            if (!Exists(dto.VideoId) && dto.VideoTitle!=null)   
            {
                VideosEntity entity = dto.toEntity();
                _repo.Create(entity);
            }
            return;
	    }


		public bool Exists(string videoId)
            => _repo.Exists(videoId);

        public VideosDto Get (string videoId)
        {
			VideosEntity entity = _repo.Get(videoId);
            return entity.toDto();
        }
	}
}
