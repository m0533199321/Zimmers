﻿using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.core.Interfaces.IRepository;
using zimmers.core.Interfaces.IService;

namespace zimmers.service.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _iRepository;
        public UserService(IUserRepository iRepository)
        {
            _iRepository = iRepository;
        }
        public IEnumerable<User> Get()
        {
            return _iRepository.GetFull();
        }
        public User? GetById(int id)
        {
           return _iRepository.GetById(id);
        }
        public bool IsValidTz(string tz)
        {
            if (tz.Length != 9)
                return false;
            int sum = 0, i = 0, plus;
            while (i < tz.Length - 1)
            {
                if (tz[i] < '0' || tz[i] > '9')
                    return false;
                plus = tz[i] - '0';
                if (i % 2 == 1)
                    plus *= 2;
                if (plus > 9)
                    plus = plus / 10 + plus % 10;
                sum += plus;
                i++;
            }
            sum %= 10;
            if (10 - sum == tz[tz.Length - 1] - '0')
                return true;
            return false;
        }
        public User Add(User user)
        {
            if (IsValidTz(user.Tz))
            {
                return _iRepository.Add(user);
            }
            return null;
        }
        public User Update(int id, User user)
        {
            
            if (IsValidTz(user.Tz))
            {
                return _iRepository.Update(id, user);
            }
            return null;
        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);
        }
    }
}