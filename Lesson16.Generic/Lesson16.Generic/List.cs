﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Lesson16.Generics
{
	public class List<T> : ICollection<T>
	{
		// can be skipped
		public IEnumerator<T> GetEnumerator()
			=> throw new NotImplementedException();

		// can be skipped
		IEnumerator IEnumerable.GetEnumerator()
			=> this.GetEnumerator();

		public void Add(T item)
		{
			throw new NotImplementedException();
		}

		public T[] GetSorted()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(T item)
			=> throw new NotImplementedException();

		// can be skipped
		public void CopyTo(T[] array, int arrayIndex)
			=> throw new NotImplementedException();

		public bool Remove(T item)
			=> throw new NotImplementedException();

		public int Count { get; }

		// can be skipped
		public bool IsReadOnly { get; }
	}
}
