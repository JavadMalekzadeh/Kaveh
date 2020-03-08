using Kaveh.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kaveh.Domain.Interfaces
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUser(string PostalCode);
        Task Create(User _user);
        Task<bool> Delete(string PostalCode);
        Task<bool> Update(User _user);
               
    }
}
