using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientRegistrationController : ControllerBase
    {
        private readonly IPatientRegistrationServices<PatientRegistration> _service;

        public PatientRegistrationController(IPatientRegistrationServices<PatientRegistration> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _service.GetAllAsync();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var patient = await _service.GetByIdAsync(id);
            if (patient == null)
            {
                return NotFound(new { Message = $"Patient with ID {id} not found." });
            }
            return Ok(patient);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatient([FromBody] PatientRegistration patient)
        {
            if (patient == null)
            {
                return BadRequest(new { Message = "Patient data is required." });
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.AddAsync(patient);
            await _service.SaveChangesAsync();  

            return CreatedAtAction(nameof(GetPatientById), new { id = patient.PatientId }, patient);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(int id, [FromBody] PatientRegistration patient)
        { 

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingPatient = await _service.GetByIdAsync(id);
            if (existingPatient == null)
            {
                return NotFound(new { Message = $"Patient with ID {id} not found." });
            }

            await _service.UpdateAsync(patient);
            await _service.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            var patient = await _service.GetByIdAsync(id);
            if (patient == null)
            {
                return NotFound(new { Message = $"Patient with ID {id} not found." });
            }

            await _service.DeleteAsync(id);
            await _service.SaveChangesAsync();
            return NoContent();
        }
    }
}
