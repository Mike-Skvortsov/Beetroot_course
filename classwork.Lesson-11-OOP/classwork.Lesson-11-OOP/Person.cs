using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork.Lesson_11_OOP
{
	public class Person
	{
		public Person()
		{

		}
		public static Person Create(string firstName, string lastName, int age)
		{
			Person person = new Person();
			person.FirstName = firstName;
			person.LastName = lastName;
			person.Age = age;

			return person;
		}
		public string FirstName;
		public string LastName;
		public int Age;

		public string FullName()
		{
			return $"{this.FirstName} {this.LastName}";
		}
		public string FullInfo()
		{
			return $"{this.FullName()}, {this.Age} years old ";
		}
		public Person(string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}
	}
}
