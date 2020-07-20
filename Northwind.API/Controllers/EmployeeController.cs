using System;
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
        [Route("GetEmployees")]
        public async Task<ActionResult<IEnumerable<string>>> GetEmplyee()
        {
            var employees = await _northwindDbContext.Employee.ToListAsync();
            return Ok(employees);
        }

        [HttpGet("GetEmployee/{id}")]
        public async Task<IActionResult> GetEmployeeAsync(int id)
        {
            var employees = await _northwindDbContext.Employee.FirstOrDefaultAsync(a => a.EmployeeId == id);
            return Ok(employees);
        }

        [HttpPost]
        // [Route("CreateEmployee")]
        public async Task<IActionResult> CreateEmployeeAsync(Employee viewModel)
        {
            if (viewModel != null)
            {
                await _northwindDbContext.Employee.AddAsync(viewModel);
                await _northwindDbContext.SaveChangesAsync();
                return Ok(viewModel);
            }
            else
            {
                return Content("No viewModel");
            }
        }

        [HttpPut]
        public async Task<ActionResult> UpdateEmployeeAsync(Employee viewModel)
        {
            try
            {
                _northwindDbContext.Update<Employee>(viewModel);
                await _northwindDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception("Error Update : Record does not exist in the database");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Ok(viewModel);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteEmployeeAsync(Employee viewModel)
        {
            try
            {
                _northwindDbContext.Remove<Employee>(viewModel);
                await _northwindDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception("Error Delete : Record does not exist in the database");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Ok();
        }
    }
}