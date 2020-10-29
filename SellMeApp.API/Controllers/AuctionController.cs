using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SellMeApp.API.Data;
using SellMeApp.API.Dtos;
using SellMeApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SellMeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _repository;

        public AuctionController(IUserRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        /*
        [HttpPost]
        public async Task<IActionResult> CreateAuction(int userId, AuctionForCreateDto auctionForCreateDto)
        {
        
            return Ok(200);
        }
        */
    } 

}

