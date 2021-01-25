using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Routing;

namespace Assignment.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    [TokenAuthenicationfilter]
    public class AccountController : ControllerBase
    {
        private readonly AssignmentContext _context;

        public AccountController(AssignmentContext context)
        {
            _context = context;
        }

        [HttpPut("RegisterAsync")]
       
        public async Task<IActionResult> RegisterAsync([FromBody] Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _context.Customers.AddAsync(customer);
                    await _context.SaveChangesAsync();
                }
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                return Ok(customer);
            }
            catch (Exception)
            {
                return BadRequest("Sorry");
                throw;
            }
        }

        [HttpGet("LogIn")]
        public async Task<IActionResult> LogIn(string emailAddress, string password)
        {
            try
            {
                Customer customer = await _context.Customers.Where(x => x.EmailAddress == emailAddress && x.Password == password)
                    .FirstOrDefaultAsync();

                if (customer != null)
                {
                    return Ok(customer);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Sorry");
                throw;
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            Customer customer = _context.Customers.Where(x => x.Id == id).FirstOrDefault();

            if (customer != null)
            {
                _context.Remove(customer);
                await _context.SaveChangesAsync();

                return Ok();
            }
            return BadRequest();
        }



        [HttpGet("ManagerLogin")]
        public async Task<IActionResult> ManagerLogin(string emailAddress, string password)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Manager staff = await _context.Managers.Where(x => x.ManagerEmail == emailAddress && x.ManagerPassword == password)
                        .FirstOrDefaultAsync();

                    if (staff != null)
                    {
                        return Ok(staff);
                    }
                }
                return BadRequest("Something went wrong");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        //Staff

        [HttpPut("AddStaff")]
        public async Task<IActionResult> AddStaff([FromBody] staff staff)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _context.staff.AddAsync(staff);
                    await _context.SaveChangesAsync();
                }
                return Ok(staff);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPut("StaffUpdateAsync")]
        public async Task<IActionResult> StaffUpdateAsync([FromBody] staff staff)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.staff.Update(staff);
                    await _context.SaveChangesAsync();
                }
                return Ok(staff);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete("DeleteStaff")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            staff staff = _context.staff.Where(x => x.Id == id).FirstOrDefault();

            if (staff != null)
            {
                _context.Remove(staff);
                await _context.SaveChangesAsync();

                return Ok(staff);
            }
            return BadRequest();
        }

        [HttpGet("StaffLogin")]
        public async Task<IActionResult> StaffLogin(string emailAddress, string password)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    staff staff = await _context.staff.Where(x => x.StaffEmail == emailAddress && x.Password == password)
                        .FirstOrDefaultAsync();

                    if (staff != null)
                    {
                        return Ok(staff);
                    }
                }
                return BadRequest("omething went wrong");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}
