using LearnYourWaether.Business;
using LearnYourWaether.Client;
using LearnYourWaether.Entities;
using LearnYourWaether.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LearnYourWaether.Views
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class TitleScreen : Page
	{
		private FavoriteViewModel _vm;

		public TitleScreen()
		{
			this.InitializeComponent();
			var client = new CityWeatherWebClient();
			var favServ = new FavoriteService();
			_vm = new FavoriteViewModel(client);

			this.DataContext = _vm;


		}


		private void myTextBox_GotFocus(object sender, RoutedEventArgs e)
		{
			myTextBox.Text = "";
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string[] userContent = myTextBox.Text.Split(',');

			City city = new FavoriteCity(userContent[0], userContent[1]);
			Frame.Navigate(typeof(ForecastView), city);
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			_vm.FillFavoriteList();
		}

		private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Frame.Navigate(typeof(ForecastView), (City)e.AddedItems.FirstOrDefault());
		}

	

	}
}

