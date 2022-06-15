namespace Lesson15.Struct
{
	partial class Program
	{
		public class Client
		{
			public string Name { get; set; }
			public string Surame { get; set; }
			public int Age { get; set; }
			public int Id { get; set; }
			private static int countID = 0;


			public Client(string name, string surame, int age)
			{
				this.Name = name;
				this.Surame = surame;
				this.Age = age;
				this.Id = Client.countID;
				Client.countID++; 
			}
		}

	}
}