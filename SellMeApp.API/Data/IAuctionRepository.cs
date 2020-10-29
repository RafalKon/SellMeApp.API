using SellMeApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellMeApp.API.Data
{
    public interface IAuctionRepository
    {
        Task<Auction> GetAuction(int id);
        Task<Auction> GetAllAuctions();
        Task<Auction> GetAllUserAuctions();


    }
}
