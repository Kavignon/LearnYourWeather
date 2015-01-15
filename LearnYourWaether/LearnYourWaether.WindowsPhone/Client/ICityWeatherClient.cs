using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnYourWaether.Client
{
   public interface ICityWeatherClient
    {
	    Task<T> DeserializeFromUrl<T>(string url);
    }
}
