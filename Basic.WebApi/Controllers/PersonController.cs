using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PersonController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public Person GetAllPersons() { 
        //{
        //    return unitOfWork.Person.GetAll();
            return unitOfWork.Person.GetById(1);
        }

        [HttpPost]
        public async Task<IActionResult> EnterPersons(Person person)
        {
            unitOfWork.Person.Add(person);
            unitOfWork.Save();
            return Ok();
        }
    }
}
