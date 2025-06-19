using HospitalManagementSystem.Data;
using HospitalManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Repositories.Services
{
    public class PatientRegistrationRepository<T>: IPatientRegistrationRepository<T> where T : class 
    {
        private readonly HospitalDbContext _context;

        public PatientRegistrationRepository(HospitalDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await SaveChangesAsync();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
    
}
