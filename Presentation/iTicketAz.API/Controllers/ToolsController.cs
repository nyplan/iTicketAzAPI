using iTicketAz.BLL.UnitOfWork.Abstract;
using iTicketAz.DAL.Contexts;
using iTicketAz.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace iTicketAz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITicketAzDbContext _context;
        public ToolsController(IUnitOfWork unitOfWork, ITicketAzDbContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        [HttpGet("agerestriction")]
        public IActionResult GetAgeRestricton()
        {
            int keyId = _context.EnumKeys.Single(k => k.Key == "agerestriction").Id;
            IQueryable<EnumValue> values = _context.EnumValues.Where(c => c.KeyId == keyId);
            return Ok(values);
        }
    }
}
