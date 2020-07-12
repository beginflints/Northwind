using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.API.Models;
using Northwind.API.Persistence;

namespace Northwind.API.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController​ : ControllerBase
    {
        private readonly NorthwindDbContext _northwindDbContext;
        public EmployeeController(NorthwindDbContext northwindDbContext) => _northwindDbContext = northwindDbContext;

        [HttpGet]
        [Route("GetEmployee")]
        public async Task<ActionResult<IEnumerable<string>>> GetEmplyee()
        {
            var employees = await _northwindDbContext.Employee.ToListAsync();
            return Ok(employees);
        }

        [HttpGet("GetEmployee/{id}")]
        public async Task<IActionResult> GetEmployeeAsync(int id)
        {
            var employee = await _northwindDbContext.Employee.Where(a=>a.EmployeeId == id).FirstOrDefaultAsync();
            return Ok(employee);
        }

        [HttpPost]
        [Route("CreateEmployee")]
        public async Task<ActionResult> CreateEmployeeAsync(Employee Model)
        {
            if (Model != null)
            {
                _northwindDbContext.Employee.Append(Model);
                await _northwindDbContext.SaveChangesAsync();
                return Ok(Model);
            }
            else
            {
                return Content("No Model");
            }
        }
    }
}