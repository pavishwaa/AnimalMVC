using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalMVC.Models;

namespace AnimalMVC.Controllers
{
	public class AnimalsController : Controller
	{
		private IData _data;

		public AnimalsController (IData data) {
			_data = data;
		}

		public IActionResult Index()
		{
			List<Animal> animals = _data.AnimalsInitializeData();

			IndexViewModel ivm = new IndexViewModel();
			ivm.Animals = animals; 

			return View(ivm);
		}

		public IActionResult Details(int? id) {
			Animal animal = _data.GetAnimalById(id);

			if (animal == null)
				return NotFound();

			return View(animal);
		}

	}
}
