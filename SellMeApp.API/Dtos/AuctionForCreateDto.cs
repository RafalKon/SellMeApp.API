using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellMeApp.API.Dtos
{
    public class AuctionForCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string IsUsed { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }

        public AuctionForCreateDto()
        {
            DateCreated = DateTime.Now;
        }

    }
}
