using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

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

        [HttpPost]
        public async Task<ActionResult> Save(Person person)
        {
           var t =  await this._unitOfWork.Person.AddAsync(person);
           var result =  this._unitOfWork.Save();
            return Ok(t);
        }
    }
}
