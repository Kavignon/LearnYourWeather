using LearnYourWaether.Business;
using LearnYourWaether.Client;
using LearnYourWaether.Entities;
using LearnYourWaether.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class ForecastView : Page
    {
		private ForecastScreenViewModel _viewModel;
		private CityWeatherWebClient _client = new CityWeatherWebClient();

		public ForecastView()
        {
            this.InitializeComponent();
        }

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			var selectedCity = (City)e.Parameter;
			InitializeDetailedPage(_client,selectedCity);
		}

		private void InitializeDetailedPage(CityWeatherWebClient client, City selectedCity)
		{
			_viewModel = new ForecastScreenViewModel(client, selectedCity);
			this.DataContext = _viewModel;
		}
		

    }

	
}
