using Kaveh.Domain.Models;
using Kaveh.Infra.Data.Infrastructure;
using Kaveh.Infra.Data.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaveh.Infra.Data.Context
{
    public class KavehDbContext : IKavehDbContext
    {
        private readonly IMongoDatabase _db; 
        public KavehDbContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionStrings);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<User> Users => _db.GetCollection<User>("Users");

        public IMongoCollection<Havaleh> Havalehs => _db.GetCollection<Havaleh>("Havalehs");
    }
}
