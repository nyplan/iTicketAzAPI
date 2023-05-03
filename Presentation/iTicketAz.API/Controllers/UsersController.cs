using iTicketAz.BLL.DTOs.UserDTOs;
using iTicketAz.BLL.UnitOfWork.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace iTicketAz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsersController(IUnitOfWork unitOfWork) { _unitOfWork = unitOfWork; }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unitOfWork.UserService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(_unitOfWork.UserService.GetById(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] UserToAddDto dto)
        {
            _unitOfWork.UserService.Add(dto);
            _unitOfWork.Commit();
            return Ok(dto);
        }
        [HttpPut]
        public IActionResult Put([FromBody] EventToUpdateDto dto)
        {
            _unitOfWork.UserService.Update(dto);
            _unitOfWork.Commit();
            return Ok(dto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _unitOfWork.UserService.Delete(id);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}
