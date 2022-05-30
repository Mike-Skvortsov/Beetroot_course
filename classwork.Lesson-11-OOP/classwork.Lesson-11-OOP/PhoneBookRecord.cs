using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork.Lesson_11_OOP
{
	public class PhoneBookRecord
	{
		private readonly Person _person;
		private readonly int _number;
		 
		public PhoneBookRecord(Person person, int number)
		{
			this._person = person;
			this._number = number;
		}

		public string FullInfo()
		{
			return $"{this._person.FullInfo()} with phone number {this._number}";
		}

	}
}
