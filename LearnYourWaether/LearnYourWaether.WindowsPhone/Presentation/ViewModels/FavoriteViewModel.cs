using LearnYourWaether.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LearnYourWaether.Client;
using System.Threading.Tasks;
using LearnYourWaether.Business;

namespace LearnYourWaether.ViewModels
{
    public class FavoriteViewModel : CommonBaseViewModel
    {

		private CityWeatherWebClient _client;
		public List<FavoriteCity> UserFavoriteCities
		{
			get
			{
				return this.GetValue<List<FavoriteCity>>();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public FavoriteViewModel(CityWeatherWebClient client)
		{
			this._client = client;
			FillFavoriteList();
		}

		public async Task FillFavoriteList()
		{
			var favCities = new List<FavoriteCity>();
			foreach(var city in FavoriteService.FavoriteCities)
			{
				city.CurrentWeather = await _client.GetCityForecast(city);
				favCities.Add(city);
			}
			UserFavoriteCities = favCities;

		}


    }
}
