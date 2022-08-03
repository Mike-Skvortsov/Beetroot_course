using Lesson36.DI.Models;
using Microsoft.AspNetCore.Mvc;
using Lesson36.DataAccess.Repositories;
using System.Threading.Tasks;
using Lesson36.Entities;
using Lesson36.BL.Services;

namespace Lesson36.DI.Controllers
{
	[ApiController]
	[Route("car")]
	public class CarController : Controller
	{
		private readonly ICarService _carService;
		public CarController(ICarService carService)
		{
			_carService = carService;
		}

		//Get
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var cars = await this._carService.GetAllAsync();
			return this.Ok(cars);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var car = await this._carService.GetByIdAsync(id);
			if (car == null)
			{
				return this.NotFound();
			}
			return this.Ok(car);
		}

		[HttpPost("create")]
		public async Task<IActionResult> Create([FromBody]CarModel model)
		{
			await this._carService.AddAsync(new Car
			{
				Year = model.Year,
				Manufacture = model.Manufacture,
				Model = model.Model
			});
			return this.Ok();
		}
		[HttpPut("{id:int}/edit")]
		public async Task<IActionResult> Update([FromBody] CarModel model, [FromRoute] int id)
		{
			var car = await this._carService.GetByIdAsync(id);
			if(car == null)
			{
				car.Manufacture = model.Manufacture;
				car.Model = model.Model;
				car.Year = model.Year;

				await this._carService.UpdateAsync(new Car
				{
					Id = id,
					Year = model.Year,
					Manufacture = model.Manufacture,
					Model = model.Model
				});
				return this.Ok();
			}
			return this.NotFound();
			
		}
		[HttpDelete("{id:int}/edit")]
		public async Task<IActionResult> Delete([FromRoute] int id)
		{
			var car = await this._carService.GetByIdAsync(id);
			if (car == null)
			{
				await this._carService.DeleteAsync(car);
				return this.Ok();
			}
			return this.NotFound();

		}
	}
}
