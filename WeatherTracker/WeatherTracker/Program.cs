using System;
using System.IO;

namespace WeatherTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduction();
            WeatherLog();
        }
        public static void Introduction()
        {
            Console.WriteLine("Hello, lets track some weather! ");
        }

        public static void WeatherLog()
        {
            string path = @"C:\Users\User-Ryzen\Desktop\WeatherTracker\WeatherLog.txt";
            string style = "**************************";
            var runtime = DateTimeOffset.Now;
            try
            {

                // Passing the filepath and filename to the StreamWriter Constructor
                StreamWriter forecast = new StreamWriter(path, append: true);

                Console.Write("Please enter the High Temperature ");
                string highTempInput = Console.ReadLine();
                forecast.WriteLine($"{highTempInput}F");

                Console.Write("Please enter the Low Temperature ");
                string lowTempInput = Console.ReadLine();
                forecast.WriteLine($"{lowTempInput}F");

                Console.Write("Please enter the Dew Point ");
                string dewPoint = Console.ReadLine();
                forecast.WriteLine($"{dewPoint}°");

                Console.Write("Please enter the Humidity ");
                string humidityInput = Console.ReadLine();
                forecast.WriteLine($"{ humidityInput}%");

                forecast.WriteLine(runtime);
                forecast.WriteLine(style);
                forecast.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Weather has been logged!");
            }
        }
    }
}
