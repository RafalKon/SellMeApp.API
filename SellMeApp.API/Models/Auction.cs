using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellMeApp.API.Models
{
    public class Auction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set;}
        public string IsUsed { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }



    }
}
