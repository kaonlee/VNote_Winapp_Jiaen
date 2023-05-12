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
	public class UsersService
	{
		private IUsersRepository _repo;
		public UsersService(IUsersRepository repo) 
		{
			_repo = repo;
		}
		
		public bool Exist (string username) // 註冊用
		=> _repo.Exists (username);

		public bool Exist(string username, string password) //登入用
		=> _repo.Exists(username,password);

		public void Insert (string username, string password) // 註冊用
		{
			if (_repo.Exists (username))
			{
				throw new Exception($@"Username 【{username}】 已經被使用，
請換一個或想想看你的密碼！");
			}
			else
			{
			_repo.Insert (username, password);
			}
		}

		public int GetUserId (string username)
		{
			return _repo.GetUserId (username);
		}

		public UsersDto Get (int userId)
		{
			return _repo.Get(userId);
		}

		public void Update (UsersDto newDto)
		{
			UsersDto originalDto = _repo.Get(newDto.UserId);
			if (_repo.Exists(newDto.UserName) && originalDto.UserName != newDto.UserName)
			{
				throw new Exception($@"Username 【{newDto.UserName}】 已經被使用，
請換一個或想想看你的密碼！");
			}
			UsersEntity entity = newDto.toEntity();
			_repo.Update(entity);
		}

		public List<UsersDto> GetAll() { return _repo.GetAll(); }
	}
}
