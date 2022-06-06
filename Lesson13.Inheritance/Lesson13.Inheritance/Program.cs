using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson13.Inheritance
{
	class Program
	{
		static void Main()
		{
			Animal animal = new Animal
			{
				Name = "Сiма",
				PawsCount = 4
			};

			Cat cat = new Cat
			{
				Name = "Капучiнка",
				PawsCount = 4
			};

			Dog dog = new Dog
			{
				Name = "Лакi",
				PawsCount = 4
			};

			Console.WriteLine($"Animal {animal.Name} with {animal.PawsCount} paws");
			Console.WriteLine($"Cat {cat.Name} with {cat.PawsCount} paws");

			animal.MakeNoise();
			cat.MakeNoise();
			dog.MakeNoise();

			Animal a;

			a = new Cat
			{
				Name = "Буся"
			};
			Cat anotherCat = new Cat
			{
				Name = "Varis",
				PawsCount = 4
			};
			a.MakeNoise();
			a = new Dog
			{
				Name = "Laki"
			};
			a.MakeNoise();

			Console.WriteLine($"{cat.Name} equal {anotherCat.Name} = {cat.Equals(anotherCat)}");
			Console.WriteLine(cat.Equals(cat));
			object obj1 = 4;
			object obj2 = "якась стрічка";

			Console.WriteLine(obj1.ToString());
			Console.WriteLine(obj2.ToString());
			Console.WriteLine(obj1.GetType());
			Console.WriteLine(obj2.GetType());

			obj1 = false;
			Console.WriteLine(obj1.ToString());
			Console.WriteLine(obj1.GetType());
			Console.WriteLine(obj1 as Nullable<int>);

			Noise noise;
			noise = new FlyNoise();
			noise.MakeNoise();

			noise = new JustNoise();
			noise.MakeNoise();

			var duck = new Duck(new FlyNoise());
			var duck1 = new Duck(new JustNoise());
			duck.MakeNoise();
			duck1.MakeNoise();


			//Homework


			var transmission = new Transmission("Mehanica", 14);
			var engine = new Engine(7, 15, "Diesel", "Yamaha");

			var Lamba = new Truck("Lamba", 2999, ConsoleColor.DarkBlue, 700, engine, transmission);
			var Yaguar = new Car("Yaguar", 2359, ConsoleColor.White, 450, engine, transmission);
			var autoService = new AutoService();
			autoService.AddVehicles(Lamba);
			autoService.AddVehicles(Yaguar);
			foreach (var item in autoService.Vehicles)
			{
				Console.WriteLine(item.FullVehicle());
			}

		}
	}
	public class AutoService
	{
		public List<Vehicle> Vehicles { get; set; }
		public AutoService()
		{
			this.Vehicles = new List<Vehicle>();
		}

		public void AddVehicles(Truck vehicle)
		{
			this.Vehicles.Add(vehicle);
		}
		public void AddVehicles(Car vehicle)
		{
			this.Vehicles.Add(vehicle);
		}
	}
	public class Engine
	{
		public Engine(int cylindersCount, int capacity, string typeOfFuel, string brand)
		{
			this.CilindresCount = cylindersCount;
			this.Capacity = capacity;
			this.TypeOfFuel = typeOfFuel;
			this.Brand = brand;

		}
		public int CilindresCount { get; set; }
		public int Capacity { get; set; }
		public string TypeOfFuel { get; set; }
		public string Brand { get; set; }
	}
	public class Transmission
	{
		public Transmission(string type, int countGear)
		{
			this.Type = type;
			this.CountGear = countGear;
		}
		public string Type { get; set; }
		public int CountGear { get; set; }
	}
	public class Vehicle
	{


		public Vehicle(string brandVehicle, int yearOfManufacture, ConsoleColor color, int maxSpeed, Engine engine, Transmission transmission)
		{
			this.BrandVehicle = brandVehicle;
			this.YearOfManufacture = yearOfManufacture;
			this.Color = color;
			this.Engine = engine;
			this.Transmission = transmission;
			this.MaxSpeed = maxSpeed;
		}
		public Engine Engine { get; set; }
		public Transmission Transmission { get; set; }
		public string BrandVehicle { get; set; }
		public int YearOfManufacture { get; set; }
		public int MaxSpeed { get; set; }

		public ConsoleColor Color { get; set; }
		public string FullVehicle()
		{
			return $"Brand this vehicle is {this.BrandVehicle} it is released in {this.YearOfManufacture}, color is {this.Color}," +
				$" max speed is {this.MaxSpeed} with engine {this.Engine.Brand} and transmission type is {this.Transmission.Type}";
		}
	}

	public class Car : Vehicle
	{
		public Car(string brandVehicle, int yearOfManufacture, ConsoleColor color, int maxSpeed, Engine engine, Transmission transmission)
		: base(brandVehicle, yearOfManufacture, color, maxSpeed, engine, transmission)
		{
		}

	}
	public class Truck : Vehicle
	{
		public Truck(string brandVehicle, int yearOfManufacture, ConsoleColor color, int maxSpeed, Engine engine, Transmission transmission)
		: base(brandVehicle, yearOfManufacture, color, maxSpeed, engine, transmission)
		{
		}
	}


	//													End Homework

	public abstract class Noise
	{
		public abstract void MakeNoise();
	}

	public class FlyNoise : Noise
	{
		public override void MakeNoise()
		{
			Console.WriteLine("Fly krya");
		}
	}

	public class SilentNoise : Noise
	{
		public override void MakeNoise()
		{
			Console.WriteLine("Тихий krya");
		}
	}
	public class JustNoise : Noise
	{
		public override void MakeNoise()
		{
			Console.WriteLine("Просто krya");
		}
	}
	public class Duck
	{
		private readonly Noise _noise;
		public Duck(Noise noise)
		{
			this._noise = noise;
		}
		public virtual void MakeNoise()
		{
			this._noise.MakeNoise();
		}
	}
	public class RubberDuck : Duck
	{
		public RubberDuck(Noise noise) : base(noise)
		{
		}
	}

	public class RealDuck : Duck
	{
		public RealDuck(Noise noise) : base(noise)
		{
		}
	}

	public class FlyDuck : RealDuck
	{
		public FlyDuck(Noise noise) : base(noise)
		{
		}
	}

	public class Animal
	{
		public string Name { get; set; }

		public int PawsCount { get; set; }

		public int Size { get; set; }

		public virtual void MakeNoise()
		{

		}
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
			{
				return true;
			}
			if (ReferenceEquals(this, null))
			{
				return false;
			}
			Animal animal = obj as Animal;
			if (animal == null)
			{
				return false;
			}
			if (this.Name != animal.Name) return false;
			if (this.Size != animal.Size) return false;
			if (this.PawsCount != animal.PawsCount) return false;
			return true;

		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	public class Cat : Animal
	{

		public override void MakeNoise()
		{
			Console.WriteLine($"{this.Name} сказала Няв!");
		}
	}

	public class Dog : Animal
	{

		public override void MakeNoise()
		{
			Console.WriteLine($"{this.Name} сказала Гав!");
		}
	}
}
