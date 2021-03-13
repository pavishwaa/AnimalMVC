﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalMVC.Models
{
	public interface IData
	{
		List<Animal> AnimalsList { get; set; }

		List<Animal> AnimalsInitializeData();
		Animal GetAnimalById(int? id);


	}
}
