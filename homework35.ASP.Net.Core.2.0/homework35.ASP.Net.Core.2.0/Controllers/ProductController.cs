using homework35.ASP.Net.Core._2._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace homework35.ASP.Net.Core._2._0.Controllers
{
	[Route("[controller]")]
	public class ProductController : Controller
	{
		[HttpGet("List")]
		public IActionResult Index()
		{
			IEnumerable<ProductModel> products = Storage<ProductModel>.Instance.GetAll();

			return View("List", products);
		}

		[HttpGet("create")]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost("create")]
		public IActionResult Create([FromForm] ProductModel model)
		{
			Storage<ProductModel>.Instance.Add(model);
			return View(model);
		}

		[HttpPost("update/{id}")]
		public IActionResult Update([FromForm] ProductModel model, [FromRoute] int id)
		{
			Storage<ProductModel>.Instance.Update(model, id);
			return View(model);
		}

		[HttpGet("update/{id}")]
		public IActionResult Update([FromRoute] int id)
		{
			var model = Storage<ProductModel>.Instance.Get(id);

			ViewData["Title"] = model.Title;
			ViewData["Price"] = model.Price;

			return View();
		}

		[HttpPost("delete/{id}")]
		public IActionResult Delete([FromRoute] int id)
		{
			Storage<ProductModel>.Instance.Delete(id);
			return View();
		}

		[HttpGet("delete/{id}")]
		public IActionResult DeleteGet([FromRoute] int id)
		{
			var model = Storage<ProductModel>.Instance.Get(id);

			ViewData["Title"] = model.Title;
			ViewData["Price"] = model.Price;

			return View();
		}
	}
}
