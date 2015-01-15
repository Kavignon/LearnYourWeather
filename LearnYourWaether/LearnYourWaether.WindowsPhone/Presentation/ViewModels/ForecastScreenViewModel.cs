using LearnYourWaether.Business;
using LearnYourWaether.Client;
using LearnYourWaether.Entities;
using LearnYourWaether.Presentation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Navigation;

namespace LearnYourWaether.ViewModels
{
	public  class ForecastScreenViewModel : CommonBaseViewModel
    {
		public ICommand RefreshCommand
		{
			get
			{
				return this.GetValue<ICommand>();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public ICommand AddFavoritesCommand
		{
			get
			{
				return this.GetValue<ICommand>();
			}
			set
			{
				this.SetValue(value);
			}
		}

		public CityWeatherWebClient _client;

	

		public Forecast Forecast
		{
			get
			{
				return this.GetValue<Forecast>();
			}
			set
			{
				this.SetValue(value);
			}
		}



		private City _city;
		public City SelectedCity
		{
			get { return _city; }
		
		}
		
		

		public ForecastScreenViewModel(CityWeatherWebClient cityWeatherClient, City city)
		{
			this._client = cityWeatherClient;
			this._city = city;

			RefreshCommand = new RelayCommand(async _ => await Refresh());
			AddFavoritesCommand = new RelayCommand(_ => AddToFavorites());

		    Refresh();

		}


		private async Task Refresh()
		{
			Forecast = await _client.GetCityForecast(_city);
		}


		private void AddToFavorites()
		{
			FavoriteService.Instance.Execute(SelectedCity);
		}

		



    }
}
