using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Entities
{
	public class MainWeatherInformation
	{
		[JsonProperty("Temp")]
		public double Temperature { get; set; }
		[JsonProperty("humidity")]
		public int HumidityPercentage { get; set; }
		[JsonProperty("pressure")]
		public double Pressure { get; set; }
		[JsonProperty("temp_min")]
		public double MinimalTemperatureInKelvin { get; set; }
		[JsonProperty("temp_max")]
		public double MaximalTemperatureInKelvin { get; set; }
	}
}
