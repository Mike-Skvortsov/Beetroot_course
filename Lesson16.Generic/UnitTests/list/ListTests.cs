using System.Linq;
using System;
using FluentAssertions;
using Lesson16.Generics;
using NUnit.Framework;

namespace UnitTests.list
{
	class ListTests
	{
		[Test]
		public void AddISSuccess_ReturnsTrue()
		{
			//Arrange
			var list = new List<Person>();
			var str = new Person("Gregorii", "Minor", "18");
			list.Add(str);
			//A
			bool result = list.array.Length != 0;
			//A
			result.Should().BeTrue();
		}
		[Test]
		public static void ClearISSuccess_ReturnsTrue()
		{
			//Arrange
			var list = new List<Person>();
			var str = new Person("Gregorii", "Minor", "18");
			list.Add(str);
			list.Add(str);
			list.Add(str);
			list.Add(str);
			list.Clear();
			//A
			bool result = true;
			for (int i = 0; i < list.array.Length; i++)
			{
				if (list.array[i] != null)
				{
					result = false;
					break;
				}
			}
			//A
			result.Should().BeTrue();
		}
		[Test]
		public static void RemoveISSuccess_ReturnsTrue()
		{
			//Arrange
			var list = new List<Person>();
			var str = new Person("Gregorii", "Minor", "18");
			list.Add(str);
			list.Remove(str);
			//A
			bool result = list.array[0] == null;
			//A
			result.Should().BeTrue();
		}
	}
}
