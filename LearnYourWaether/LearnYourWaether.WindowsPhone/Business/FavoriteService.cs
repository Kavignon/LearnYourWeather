using LearnYourWaether.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LearnYourWaether.Business
{
   public sealed class FavoriteService : IServiceProvider
    {
	   private static FavoriteService instance = null;
	   private static readonly object lockingObject = new object();
	   private static List<FavoriteCity> _favCities;
	   public static List<FavoriteCity> FavoriteCities 
		{ 
			get
			{
				return _favCities; 
			}
			set
			{
				_favCities = value;
			}
		}

		public static FavoriteService Instance
		{
			get
			{

				lock (lockingObject)
				{
					if (instance == null)
					{
						instance = new FavoriteService();
						FavoriteCities = new List<FavoriteCity>();
					}
					return instance;
				}
			}
		}

		public void AddCityToFavorites(FavoriteCity city)
		{


			if(!FavoriteCities.Any(favCity => favCity.CityName == city.CityName && favCity.CountryCode.Equals(city.CountryCode)))
			{
				FavoriteCities.Add(city);
			}
		}
	   

	   public bool CanExecute(object parameter){
		  return  true;
	   }

	   public event EventHandler CanExecuteChanged;

	   public  void Execute(object parameter)
	   {

		   AddCityToFavorites((FavoriteCity)parameter);
	   }
	}
}
