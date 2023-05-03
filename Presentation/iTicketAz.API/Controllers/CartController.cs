using AutoMapper;
using iTicketAz.BLL.DTOs.CartDTOs;
using iTicketAz.DAL.Contexts;
using iTicketAz.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace iTicketAz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ITicketAzDbContext _context;
        private readonly IMapper _mapper;
        public CartController(ITicketAzDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("id")]
        public IActionResult Post(CartToAddByUserIdDto dto)
        {
            var data = _mapper.Map<CartUserId>(dto);
            _context.Carts.Add(data);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost("data")]
        public IActionResult Post(CartToAddByUserDataDto dto)
        {
            var data = _mapper.Map<CartUserData>(dto);
            _context.Carts.Add(data);
            _context.SaveChanges();
            return Ok();
        }
    }
}
