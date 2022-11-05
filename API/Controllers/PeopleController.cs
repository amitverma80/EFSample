using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PeopleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PeopleController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;            
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetAllAsync()
        {
            var p = await this._unitOfWork.Person.GetAllAsync();

            return Ok(p);
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<Person>> GetAll()
        //{
        //    var p = this._unitOfWork.Person.GetAll();

        //    return Ok(p);
        //}
    }
}
