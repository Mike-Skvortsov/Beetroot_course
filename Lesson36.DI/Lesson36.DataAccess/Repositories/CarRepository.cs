using Lesson36.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson36.DataAccess.Repositories
{
	public interface ICarRepository
	{
		Task<ICollection<Car>> GetAllAsync();
		Task<Car> GetByIdAsync(int id);
		Task AddAsync(Car car);
		Task UpdateAsync(Car car);
		Task DeleteAsync(Car car);
	}

	public class CarRepository: ICarRepository
	{
		private readonly LessonDataContext _context;
		public CarRepository(LessonDataContext context)
		{
			this._context = context;
		}
		public async Task<ICollection<Car>> GetAllAsync()
		{
			return await this._context.Cars.ToListAsync();
		}
		public async Task<Car> GetByIdAsync(int id)
		{
			return await this._context.Cars.FirstOrDefaultAsync(x => x.Id == id);
		}
		public async Task AddAsync(Car car)
		{
			await this._context.Cars.AddAsync(car);
			await this._context.SaveChangesAsync();
		}
		public async Task UpdateAsync(Car car)
		{
			this._context.Cars.Update(car);
			await this._context.SaveChangesAsync();
		}
		public async Task DeleteAsync(Car car)
		{
			this._context.Cars.Remove(car);
			await this._context.SaveChangesAsync();
		}
	}
}
