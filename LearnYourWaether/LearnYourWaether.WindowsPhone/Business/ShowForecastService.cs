using LearnYourWaether.Client;
using LearnYourWaether.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Business
{
   /*public  class WeatherService : IServiceProvider
    {
	   public WeatherService()
		{
			this.CityName = name;
			this.CityCode = code.ToUpper() ;
		}

	   public async Task<Forecast> GetForecast(string name, string code)
	   {
		   CityWeatherWebClient client = new CityWeatherWebClient();
		   CityForecast = await client.GetCityForecast(CityName, CityCode);
	   }


	   public async Task LoadCityForecast()
	   {
		   CityWeatherWebClient client = new CityWeatherWebClient();
		   CityForecast = await client.GetCityForecast(CityName, CityCode);

	   }

	   public bool CanExecute(object parameter)
	   {
		   if(CityForecast== null)
		   {
			   return false;
		   }
		   else
		   {
			   return true;
		   }
	   }

	   public event EventHandler CanExecuteChanged;

	   public async void Execute(object parameter)
	   {
		    await LoadCityForecast();
	   }
	}*/
}
