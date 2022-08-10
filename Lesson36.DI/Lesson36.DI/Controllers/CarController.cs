using System.Threading.Tasks;
using AutoMapper;
using Lesson36.BL.Services;
using Lesson36.Di.Models;
using Lesson36.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Lesson36.Di.Controllers
{
    [ApiController]
    [Route("car")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;

        public CarController(ICarService carService, IMapper mapper)
        {
            this._carService = carService;
            this._mapper = mapper;
        }

        // GET
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
        public async Task<IActionResult> Create([FromBody] CarModel model)
        {
            var car = this._mapper.Map<Car>(model);
            await this._carService.AddAsync(car);
            return this.Ok();
        }

        [HttpPut("{id:int}/edit")]
        public async Task<IActionResult> Update([FromBody] CarModel model, [FromRoute] int id)
        {
            var car = await this._carService.GetByIdAsync(id);
            if (car != null)
            {
                car.Manufacturer = model.Manufacturer;
                car.Model = model.Model;
                car.Year = model.Year;

                await this._carService.UpdateAsync(car);

                return this.Ok();
            }

            return this.NotFound();
        }

        [HttpDelete("{id:int}/delete")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var car = await this._carService.GetByIdAsync(id);
            if (car != null)
            {
                await this._carService.DeleteAsync(car);

                return this.Ok();
            }

            return this.NotFound();
        }
    }
}