using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkEntry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMployeeController : ControllerBase
    {
        private readonly ORM.TechCareerDbContext _context;

        public EMployeeController()
        {
            _context = new ORM.TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Create(Models.Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created,employee);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return Ok(employee);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Models.Employee employee)
        {
            var employeeFromDb = _context.Employees.Find(id);
            if (employeeFromDb == null)
            {
                return NotFound();
            }
            employeeFromDb.FirstName = employee.FirstName;
            employeeFromDb.LastName = employee.LastName;
            employeeFromDb.Adress = employee.Adress;
            employeeFromDb.BirthDate = employee.BirthDate;
            employeeFromDb.City = employee.City;
            employeeFromDb.AddTime = employee.AddTime;
            _context.SaveChanges();
            return Ok(employeeFromDb);
        }
    }
}
