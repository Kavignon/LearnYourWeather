using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Entities
{
	public class City
	{
		public string CityName { get; set; }

		public string CountryCode { get; set; }

		public City(string name, string code)
		{
			this.CityName = name;
			this.CountryCode = code;
		}

		public City() { }

		public override string ToString()
		{
			return CityName + "," + CountryCode;
		}
	}
}
