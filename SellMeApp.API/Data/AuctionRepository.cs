using Microsoft.EntityFrameworkCore;
using SellMeApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellMeApp.API.Data
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly DataContext _context;

        public AuctionRepository(DataContext context)
        {
            _context = context;
        }

        public Task<Auction> GetAllAuctions()
        {
            throw new NotImplementedException();
        }

        public Task<Auction> GetAllUserAuctions()
        {
            throw new NotImplementedException();
        }

        public async Task<Auction> GetAuction(int id)
        {
            var auction = await _context.Auctions.FirstOrDefaultAsync(a => a.Id == id);
            return auction;
        }
    }
}
