using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Weather
    {
        private Random random;
        public string DayWeather;

        public Weather()
        {
            random = new Random();
            DayWeather = GetWeather();
        }

        public string GetWeather()
        {
            int rndnumb = random.Next(1, 6);
            
            if (rndnumb == 1)
            {
                string weather = "Sunny";
                return weather;
            }
            if (rndnumb == 2)
            {
                string weather = "Cloudy";
                return weather;
            }
            if (rndnumb == 3)
            {
                string weather = "Windy";
                return weather;
            }
            if (rndnumb == 4)
            {
                string weather = "Rainy";
                return weather;
            }
            if (rndnumb == 5)
            {
                string weather = "Stormy";
                return weather;
            }
            return "";
            
        } 



    }
}
