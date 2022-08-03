using Lesson36.DataAccess.Repositories;
using Lesson36.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	public class CarService: ICarService
	{
		private readonly ICarRepository _carRepository;
		public CarService(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public Task AddAsync(Car car) => this._carRepository.AddAsync(car);

		public Task DeleteAsync(Car car) => this._carRepository.DeleteAsync(car);

		public Task<ICollection<Car>> GetAllAsync() => this._carRepository.GetAllAsync();

		public Task<Car> GetByIdAsync(int id) => this._carRepository.GetByIdAsync(id);)

		public Task UpdateAsync(Car car) => this._carRepository.UpdateAsync(car);
	}
}
