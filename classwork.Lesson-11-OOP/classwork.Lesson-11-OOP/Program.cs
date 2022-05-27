using System;

namespace classwork.Lesson_11_OOP
{
	class Program
	{
		static void Main()
		{
			Person person = new Person();
			person.FirstName = "Misha";
			person.LastName = "Skvortsov";
			person.Age = 20;

			var anotherPerson = new Person("Andi", "Smith", 25);
			var thirdPerson = Person.Create("Dima", "Olefir", 33);

            var fourthPerson = new Person
            {
                FirstName = "Nick",
                LastName = "Someone"
            };

            Print(person);
            Print(anotherPerson);
            Print(thirdPerson);
            Print(fourthPerson);

            var records = new PhoneBookRecord[]
            {
                new PhoneBookRecord(person, 123),
                new PhoneBookRecord(anotherPerson, 456),
                new PhoneBookRecord(thirdPerson, 789),
                new PhoneBookRecord(fourthPerson, 000)
            };
            var phoneBook = new PhoneBook(records);
            foreach (var item in phoneBook.Records)
            {
                Console.WriteLine(item.FullInfo());
            }
        }

        private static void Print(Person person)
		{
			Console.WriteLine($"{person.FullInfo()}");
		}
	}
}
