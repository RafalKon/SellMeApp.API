using PagedList;
using SellMeApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellMeApp.API.Data
{
    public interface IUserRepository : IGenericRepository
    {
        Task<User> GetUser(int id);
        Task<User> GetAllUsers();

    }
}
