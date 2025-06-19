using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetAll()
        {
            var types = await _service.GetAllAsync();
            return Ok(types);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post( PatientRegistration data)
        {
            await _service.AddAsync(data);
            await _service.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = data.PatientId }, data);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PatientRegistration data)
        {
            if (id != data.PatientId) return BadRequest();
            await _service.UpdateAsync(data);
            await _service.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            await _service.SaveChangesAsync();
            return NoContent();
        }
    }
}
