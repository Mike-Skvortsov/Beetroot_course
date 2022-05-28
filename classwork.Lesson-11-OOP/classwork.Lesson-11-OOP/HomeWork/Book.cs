using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork.Lesson_11_OOP.HomeWork
{
	class Book
	{
		public int Page;
		public Autor[] Autors;
		public Genre[] Genres;
		public string NameBook;
		public Book(int pages, Autor[] autors, Genre[] genre, string nameBook)
		{
			this.Page = pages;
			this.Autors = autors;
			this.Genres = genre;
			this.NameBook = nameBook;
		}
		public string FullData()
		{
			string allAutors = "";
			string allGenres = "";
			foreach (var item in Autors)
			{
				allAutors += $"{item.AutorBook} and ";
			}
			foreach (var item in Genres)
			{
				allGenres += $"{item.GenreBook} and ";
			}
			return $"{allAutors[0..^4]}is autors of {this.NameBook} and this book has {this.Page} pages.\nGenres: {allGenres[0..^4]}";
		}
	}
}
