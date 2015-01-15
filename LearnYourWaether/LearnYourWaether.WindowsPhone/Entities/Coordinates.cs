using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Entities
{
	public class Coordinates
	{
		[JsonProperty("lon")]
		public double Lontitude { get; set; }
		[JsonProperty("lat")]
		public double Latitude { get; set; }
	}

}
