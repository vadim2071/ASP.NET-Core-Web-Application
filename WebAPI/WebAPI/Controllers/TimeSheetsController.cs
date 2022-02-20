using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.Models;
using TimeSheets.BD;


//GET /persons/search?searchTerm={term} — поиск человека по имени
//GET / persons /{ id} — получение человека по идентификатору
//GET /persons/?skip={5}&take ={ 10} — получение списка людей с пагинацией
//POST /persons — добавление новой персоны в коллекцию
//PUT /persons — обновление существующей персоны в коллекции
//DELETE /persons/{id} — удаление персоны из коллекции

namespace TimeSheets.main.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeSheetsController : ControllerBase
    {
        private readonly IRepository<Person> _repository;



        [HttpGet]
        [Route("{id}")]
        public IActionResult Persons([FromRoute] int id) =>
            _repository.GetAll().FirstOrDefault(p => p.Id == id) is Person person ?
            Ok(person) : (IActionResult)NotFound();

        [HttpGet]
        [Route("search")]
        public IActionResult Persons([FromQuery] string searchTerm) =>
            _repository.GetAll().FirstOrDefault(p => p.FirstName == searchTerm) is Person person ?
            Ok(person) : (IActionResult)NotFound();

        [HttpGet]
        public IActionResult Persons(PersonPageNavDto personPageNav) =>
            Ok(_repository.GetAll().Skip(personPageNav.Skip).Take(personPageNav.Take));

        [HttpPost]
        public IActionResult PersonsAdd([FromBody] Person person) =>
            _repository.New(person) ? (IActionResult)Ok() : Conflict("id person is already created.");


        [HttpPut]
        public IActionResult PersonsUpdate([FromBody] Person person) =>
            _repository.Update(person) ? (IActionResult)Ok() : NotFound();

        [HttpDelete]
        [Route("{id}")]
        public IActionResult PersonsDelete([FromRoute] int key) =>
            _repository.Delete(key) ? (IActionResult)Ok() : NotFound();
    }
}
