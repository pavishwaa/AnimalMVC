using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalMVC.Models
{
	public class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageName { get; set; }
		public string Information { get; set; }
		public string Category { get; set; }
	}
}
