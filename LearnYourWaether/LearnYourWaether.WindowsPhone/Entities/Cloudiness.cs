using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Entities
{
	public class Cloudiness
	{
		[JsonProperty("all")]
		public int CloudinessPercentage { get; set; }
	}
}
