using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace LearnYourWaether.Business
{
	class KelvinToCelsiusConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			// Kelvin to Celsius
			double kelvin;
			if (double.TryParse(value.ToString(), out kelvin))
			{
				var celsius = kelvin - 273.15;
				
				return Math.Round(celsius,2) + " °C";
			}

			throw new ArgumentException("value must be double");
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			// Celsius to Fahrenheit
			double celsius;
			if (double.TryParse(value.ToString(), out celsius))
			{
				var kelvin = celsius + 273.15;
				return kelvin;
			}

			throw new ArgumentException("value must be double");
		}
	}
}
