using HospitalManagementSystem.Repositories.Interfaces;

namespace HospitalManagementSystem.Repositories.Services
{
    public class PatientRegistrationServices<T> : IPatientRegistrationServices<T> where T : class
    {
        private readonly IPatientRegistrationRepository<T> _repository;

        public PatientRegistrationServices(IPatientRegistrationRepository<T> repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task AddAsync(T entity)
        {
            return _repository.AddAsync(entity);
        }

        public Task UpdateAsync(T entity)
        {
            return _repository.UpdateAsync(entity);
        }

        public Task DeleteAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task SaveChangesAsync()
        {
            return _repository.SaveChangesAsync();
        }
    }
}
