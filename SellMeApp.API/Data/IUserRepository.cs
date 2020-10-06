using SellMeApp.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellMeApp.API.Data
{
    interface IUserRepository : IGenericRepository
    {
        Task<User> GetUser(int id);
    }
}
