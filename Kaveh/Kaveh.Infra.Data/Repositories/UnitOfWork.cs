using Kaveh.Domain.Models;
using Kaveh.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaveh.Infra.Data.Repositories
{
    public class UnitOfWork
    {
        private readonly IKavehDbContext _db;
        public UnitOfWork(IKavehDbContext dbContext)
        {
            _db = dbContext;
        }
        private GenericRepo<User> _userRepo;
        private GenericRepo<Havaleh> _havalehRepo;
        public GenericRepo<User> UserRepository => _userRepo ?? new GenericRepo<User>(_db.Users);
        public GenericRepo<Havaleh> HavalehRepository => _havalehRepo ?? new GenericRepo<Havaleh>(_db.Havalehs);
    }
}
