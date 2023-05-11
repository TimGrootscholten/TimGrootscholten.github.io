using koishowweb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace koishowweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        private readonly DbContextKoi _dbContextKoi;

        public TemperatureController(DbContextKoi dbContextKoi)
        {
            _dbContextKoi = dbContextKoi;
        }


        // GET: api/<TemperatureController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TemperatureController>/5
        [HttpGet("{id}/{aantal}")]
        public List<DoubleTime> Get(string id, int aantal)
        {
            return _dbContextKoi.Temperature
                .Where(x => x.Sensor == _dbContextKoi.Sensor.FirstOrDefault(x => x.SensorId == id))
                .OrderByDescending(x => x.CreatedOn)
                .Take(aantal)
                .Select((x => new DoubleTime { value = x.Temperature, DateTime = x.CreatedOn.ToString("HH:mm") }))
                .Reverse()
                .ToList();
        }

        // POST api/<TemperatureController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TemperatureController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TemperatureController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
