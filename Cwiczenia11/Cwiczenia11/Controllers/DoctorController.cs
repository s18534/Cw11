using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia11.Controllers
{

    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ClinicDbContext context;
        public DoctorController(ClinicDbContext con)
        {
            context = con;
        }
        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(context.Doctors.ToList());
        }

        [HttpPut("update")]
        public IActionResult UpdateDoctor(Doctor doctor)
        {
            try
            {
                context.Attach(doctor);
                context.SaveChanges();
                return Ok("Doktor został zmodyfikowany");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            var d = new Doctor
            {
                IdDoctor = id
            };
            context.Attach(d);
            context.Remove(d);
            context.SaveChanges();
            return Ok($"Doctor {id} usunięty pomyślnie");
        }

        [HttpPost]
        public IActionResult InsertDoctor(Doctor doctor)
        {
            context.Add(doctor);
            context.SaveChanges();
            return Ok(context.Doctors.ToList());
        }

        [HttpPost]
        public IActionResult Seed()
        {
            context.Add(
                new Doctor
                {
                    IdDoctor = 1,
                    FirstName = "Marcin",
                    LastName = "Kowalski",
                    Email = "marcinKowalski@wp.pl"
                });
            context.SaveChanges();
            return Ok(context.Doctors.ToList());
        }
}
}
