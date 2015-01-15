using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Entities
{
	public class FavoriteCity : City
	{
		public DateTime CurrentTime { get; set; }
		public Forecast CurrentWeather { get; set; }

		public FavoriteCity(string name, string code) : base(name, code) { }

		

	}
}
