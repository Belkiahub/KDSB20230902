using KDSB20230902.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KDSB20230902.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        static List<Alumno> alumnos = new List<Alumno>();

        // GET: api/<AlumnoController>
        [HttpGet]
        public IEnumerable<Alumno> Get()
        {
            return alumnos;
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public Alumno Get(int id)
        {
            var alumn = alumnos.FirstOrDefault(c => c.Id == id);
            return alumn;
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public IActionResult Post([FromBody] Alumno alumno)
        {
            alumnos.Add(alumno);
            return Ok();
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Alumno alumno)
        {
            var existingAlumn = alumnos.FirstOrDefault(c => c.Id == id);
            if (existingAlumn != null)
            {
                existingAlumn.Name = alumno.Name;
                existingAlumn.Lastname = alumno.Lastname;
                existingAlumn.grade = alumno.grade;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingAlumn = alumnos.FirstOrDefault(c => c.Id == id);
            if (existingAlumn != null)
            {
                alumnos.Remove(existingAlumn);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
