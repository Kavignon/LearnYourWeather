using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Entities
{
	public class Forecast
	{

		[JsonProperty("cood")]
		public Coordinates Coordinates { get; set; }
		[JsonProperty("sys")]
		public Sys sys { get; set; }
		[JsonProperty("weather")]
		public List<Weather> Weather { get; set; }
		[JsonProperty("base")]
		public string WeatherStation { get; set; }
		[JsonProperty("main")]
		public MainWeatherInformation WeatherInfomration { get; set; }
		//[JsonProperty("wind")]
		//public Wind Wind { get; set; }
		[JsonProperty("rain")]
		public Rain Rain { get; set; }
		[JsonProperty("clouds")]
		public Cloudiness Cloudiness { get; set; }
		[JsonProperty("dt")]
		public int DataReceivingTime { get; set; }
		[JsonProperty("id")]
		public int CityIdentification { get; set; }
		[JsonProperty("name")]
		public string name { get; set; }
		public int cod { get; set; }
	}


}
