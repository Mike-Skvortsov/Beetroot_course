using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson16.Generics
{
	public class List<T> : ICollection<T>
	{
		public T[] array = Array.Empty<T>();

		// can be skipped
		public IEnumerator<T> GetEnumerator()
			=> throw new NotImplementedException();

		// can be skipped
		IEnumerator IEnumerable.GetEnumerator()
			=> this.GetEnumerator();

		public void Add(T item)
		{
			var newArray = new T[array.Length + 1];
			for (int i = 0; i < array.Length; i++)
			{
				newArray[i] = array[i];
			}
			newArray[newArray.Length - 1] = item;
			array = newArray;
		}


		public T[] GetSorted()
		{
			Array.Sort<T>(array);
			return array;
		}


		public void Clear()
		{
			Array.Clear(array, 0, array.Length);
		}

		public bool Contains(T item)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if(array[i].Equals(item))
				{
					return true;
				}
			}
			return false;
		}
		// can be skipped
		public void CopyTo(T[] array, int arrayIndex)
			=> throw new NotImplementedException();

		public bool Remove(T item)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Equals(item))
				{
					Array.Clear(array, i, 1);
					return true;
				}
			}
			return false;
		}
		public int Count { get; }

		// can be skipped
		public bool IsReadOnly { get; }
	}
}
