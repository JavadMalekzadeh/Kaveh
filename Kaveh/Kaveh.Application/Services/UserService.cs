using Kaveh.Application.Interfaces;
using Kaveh.Application.ViewModels;
using Kaveh.Domain.Models;
using Kaveh.Infra.Data.Interfaces;
using Kaveh.Infra.Data.Repositories;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaveh.Application.Services
{
    public class UserService : IUserService
    {
        private readonly UnitOfWork _unitOfWork;
        public UserService(IKavehDbContext dbContext)
        {
            _unitOfWork = new UnitOfWork(dbContext);
        }
        public UserViewModel GetUserDetailsAll()
        {
            var Usrs = _unitOfWork.UserRepository.Quary;
            return new UserViewModel()
            {
                UserDetails = (IMongoQueryable<User>)Usrs
            };
            
        }
    }
}
