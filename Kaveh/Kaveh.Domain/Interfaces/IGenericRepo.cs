using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kaveh.Domain.Interfaces
{
    public interface IGenericRepo<T> where T:class,new()
    {
        IMongoQueryable<T> Quary { get; }
        Task<T> GetOne(Expression<Func<T, bool>> expression);
        Task<DeleteResult> Delete(Expression<Func<T, bool>> expression);
        Task InsertOne(T item);
        Task<UpdateResult> UpdateOne(Expression<Func<T, bool>> expression, UpdateDefinition<T> Update);
    }
}
