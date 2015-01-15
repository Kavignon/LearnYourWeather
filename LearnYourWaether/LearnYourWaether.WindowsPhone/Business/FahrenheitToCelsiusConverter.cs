using LearnYourWaether.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace LearnYourWaether.Business
{
	public class FahrenheitToCelsiusConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			// Fahrenheit to Celsius
			double fahrenheit;
			if (double.TryParse(value.ToString(), out fahrenheit))
			{
				var celsius = (fahrenheit - 32) * 5 / 9;
				return celsius;
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
				var fahrenheit = celsius * 9 / 5 + 32;
				return fahrenheit;
			}

			throw new ArgumentException("value must be double");
		}
	}
}
