using LearnYourWaether.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Client
{
	public class CityWeatherWebClient
	{
		private const string BaseUrl = "http://api.openweathermap.org/data/2.5/";



		/// <summary>
		/// Generic method to deserialize objects from url
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="url"></param>
		/// <returns></returns>
		private  async Task<T> DeserializeFromUrl<T>(string url)
		{
			
			var client = new HttpClient(); // Create my client
			var json = await client.GetStringAsync(url);
			var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
			return obj;
		}

		public async Task<Forecast> GetCityForecast(City city)
		{

			var url = BaseUrl + "weather?q=" + city.CityName + "," + city.CountryCode + "&APPID=f4b81965a458eee237c7305ec25c4d4f";
			var forecast = await DeserializeFromUrl<Forecast>(url);
			
			return forecast;
		}




	}
}
