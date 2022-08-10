using System.Collections.Generic;
using System.Threading.Tasks;
using Lesson36.DataAccess.Repositories;
using Lesson36.Entities;

namespace Lesson36.BL.Services
{
    public interface ICarService
    {
        Task<ICollection<Car>> GetAllAsync();
        Task<Car> GetByIdAsync(int id);
        Task AddAsync(Car car);
        Task UpdateAsync(Car car);
        Task DeleteAsync(Car car);
    }

    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            this._repository = repository;
        }

        public Task<ICollection<Car>> GetAllAsync()
            => this._repository.GetAllAsync();

        public Task<Car> GetByIdAsync(int id)
            => this._repository.GetByIdAsync(id);

        public Task AddAsync(Car car)
            => this._repository.AddAsync(car);

        public Task UpdateAsync(Car car)
            => this._repository.UpdateAsync(car);

        public Task DeleteAsync(Car car)
            => this._repository.DeleteAsync(car);
    }
}