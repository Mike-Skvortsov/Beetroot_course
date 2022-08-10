using System.Collections.Generic;
using System.Threading.Tasks;
using Lesson36.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson36.DataAccess.Repositories
{
    public class CarRepositoryCopy : ICarRepository
    {
        private readonly LessonDataContext _context;

        public CarRepositoryCopy(LessonDataContext context)
        {
            this._context = context;
        }

        public async Task<ICollection<Car>> GetAllAsync()
        {
            return await this._context.Cars.ToListAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await Task.FromResult(new Car
            {
                Model = "my fk car",
                Manufacturer = "сам вдома склепав"
            });
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