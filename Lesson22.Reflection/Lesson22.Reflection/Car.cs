using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22.Reflection
{
	public class Vehicle
	{
		public Vehicle(string brandVehicle, int yearOfManufacture, ConsoleColor color, int maxSpeed)
		{
			this.BrandVehicle = brandVehicle;
			this.YearOfManufacture = yearOfManufacture;
			this.Color = color;
			this.MaxSpeed = maxSpeed;
		}
		public string BrandVehicle { get; set; }
		public int YearOfManufacture { get; set; }
		public int MaxSpeed { get; set; }

		public ConsoleColor Color { get; set; }
		public string Print()
		{
			return $"Brand this vehicle is {this.BrandVehicle} it is released in {this.YearOfManufacture}, color is {this.Color}," +
				$" max speed is {this.MaxSpeed}";
		}
	}

	public class Car : Vehicle
	{
		public Car(string brandVehicle, int yearOfManufacture, ConsoleColor color, int maxSpeed)
		: base(brandVehicle, yearOfManufacture, color, maxSpeed)
		{
		}
	}
}
