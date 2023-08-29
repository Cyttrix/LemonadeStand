using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        //member variables
        public string WeatherPref;
        public int MoneyPref;
        private Random rnd;
        //constructor
        public Customer()
        {
            rnd = new Random();
            WeatherPref = GetWeatherPref();
            MoneyPref = GetMoneyPref();
        }

        //memeber methods
        public string GetWeatherPref()
        {
            int randNumber = rnd.Next(1,6);
            
            if(randNumber == 1)
            {
                string preference = "Sunny";
                return preference;
            }
            else if(randNumber == 2)
            {
                string preference = "Cloudy";
                return preference;
            }
            else if (randNumber == 3)
            {
                string preference = "Windy";
                return preference;
            }
            else if (randNumber == 4)
            {
                string preference = "Rainy";
                return preference;
            }
            else
            {
                string preference = "Stormy";
                return "Stormy";
            }
         
            
            
        }

        public int GetMoneyPref()
        {
            int moneyPref = rnd.Next(1, 6);
            
            
            return moneyPref;
        }
        public bool BuyLemonade(int priceOfCup, string Weather)
        {
           if (MoneyPref <= priceOfCup && WeatherPref == Weather)
            {
                return true;

            }
           else
            {
                return false;
            }

            
        }
       

    }
}
