using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.BL;


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

        private readonly ILogger<TimeSheetsController> _logger;

        public TimeSheetsController(ILogger<TimeSheetsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            
        }
    }
}
