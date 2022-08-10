using FluentAssertions;
using Lesson36.BL.Services;
using Lesson36.DI.Controllers;
using Lesson36.DI.Models;
using Lesson36.Entities;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Lesson36.UnitTests
{
	public class CarControllerTests
	{
		[Test]
		public async Task TestAsync1()
		{
			//Arrange
			var service = new Mock<ICarService>();
			var controller = new CarController(service.Object);

			//Act

			var result = await controller.Get();
			var okObject = result as OkObjectResult;

			//Assert
			okObject.StatusCode.Should().Be((int)HttpStatusCode.OK);
		}

		[Test]
		public async Task TestAsync2()
		{
			//Arrange
			var service = new Mock<ICarService>();
			service.Setup(x => x.GetAllAsync()).ReturnsAsync(new List<Car>
			{
				new Car
				{
					Manufacture = "wefw"
				}
			});
			var controller = new CarController(service.Object);

			//Act

			var result = await controller.Get();
			var okObject = result as OkObjectResult;

			//Assert
			okObject.StatusCode.Should().Be((int)HttpStatusCode.OK);
			okObject.Value.Should().BeEquivalentTo(new List<CarModel>
			{
				new CarModel
				{
					Manufacture = "wewf"
				}
			});
		}
	}
}
