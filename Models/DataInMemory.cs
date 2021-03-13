using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalMVC.Models
{
	public class DataInMemory : IData
	{
		public List<Animal> AnimalsList { get; set; }

		public List<Animal> AnimalsInitializeData()
		{
			AnimalsList = new List<Animal>() {
				new Animal(){
					Id = 101,
					Name = "Elephant"  ,
					Category ="Mammal",
					Information = "Warm-blooded, given birth to live babies." ,
					ImageName = "elephant.jpg"
				},
				new Animal(){
					Id = 102,
					Name = "Snake",
					Category ="Reptile",
					Information = "Clod-blooded, lay eggs." ,
					ImageName = "snake.jpg"
				},
				new Animal(){
					Id = 103,
					Name = "Shark"  , 
					Category ="Fish",
					Information = "Clod-blooded, have fins." ,
					ImageName = "fish.jpg"
				},
				new Animal(){
					Id = 104,
					Name = "Parrot",
					Category ="Bird",
					Information = "Can fly, lay eggs." ,
					ImageName = "parrot.jpg"
				}
			};

			return AnimalsList;
		}

		public Animal GetAnimalById(int? id)
		{
			if (id == null)
			{
				return null;
			}
			else {
				return AnimalsList.SingleOrDefault(a => a.Id == id);			
			}
		}
	}
}
