using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork.Lesson_11_OOP
{
	public class PhoneBookRecord
	{
		public Person Person;
		public int Number;
		public PhoneBookRecord(Person person, int number)
		{
			this.Person = person;
			this.Number = number;
		}
		public string FullInformation()
		{
			return $"{this.Person.FullInfo()} with phone number {this.Number}";
		}

	}
}
