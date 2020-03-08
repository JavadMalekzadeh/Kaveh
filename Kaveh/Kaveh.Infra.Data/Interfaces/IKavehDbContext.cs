using Kaveh.Domain.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaveh.Infra.Data.Interfaces
{
    public interface IKavehDbContext
    {
        IMongoCollection<User> Users { get; } 
        IMongoCollection<Havaleh> Havalehs { get; }
    }
}
