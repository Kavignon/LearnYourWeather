using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Entities
{
	public class Weather
	{
		[JsonProperty("id")]
		public int WeatherConditionId { get; set; }
		[JsonProperty("main")]
		public string WeatherParametersGroup { get; set; }
		[JsonProperty("description")]
		public string WeatherCondtionGroupDescription { get; set; }
		[JsonProperty("icon")]
		public string WeatherConditionIconID { get; set; }


		public string WeatherConditionIcon 
		{
			get
			{
				return "http://openweathermap.org/img/w/" + WeatherConditionIconID + ".png";
			}
		}
	}
}
