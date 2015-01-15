using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Entities
{
	public class Rain
	{
		[JsonProperty ("3h") ]
		public double LastThreeHours { get; set; }
	}
}
