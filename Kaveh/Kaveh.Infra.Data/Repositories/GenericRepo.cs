using Kaveh.Domain.Interfaces;
using Kaveh.Infra.Data.Interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kaveh.Infra.Data.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T:class,new()
    {
        private readonly IMongoCollection<T> _collection;
        
        public GenericRepo(IMongoCollection<T> collection)
        {
            _collection = collection;
        }

        public IMongoQueryable<T> Quary => _collection.AsQueryable<T>();

        public async Task<DeleteResult> Delete(Expression<Func<T, bool>> expression)
        {
            return await _collection.DeleteOneAsync(expression);
        }

        public async Task<T> GetOne(Expression<Func<T, bool>> expression)
        {
            return await _collection.Find(expression).SingleOrDefaultAsync();
        }

        public async Task InsertOne(T item)
        {           
            await _collection.InsertOneAsync(item);            
        }

        public async Task<UpdateResult> UpdateOne(Expression<Func<T, bool>> expression, UpdateDefinition<T> Update)
        {
           return await _collection.UpdateOneAsync(expression, Update);
        }
    }
}
