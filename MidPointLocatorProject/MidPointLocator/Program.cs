using MidPointLocator.Models;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MidPointLocator
{
    class Program
    {
        public static void Main(string[] args)
        {
            var response = GetLocations();

            if (response?.Result?.Result != null)
            {
                var validLocations = response.Result.Result.Where(x => x.Location != null);
                if (validLocations.Any())
                {
                    var longitudes = validLocations.Select(x => x.Location.Longitude);
                    var latitudes = validLocations.Select(x => x.Location.Latitude);
                    var postcodes = validLocations.Select(x => x.Postcode);

                    var centerLongitude = longitudes.Average();
                    var centerLatitude = latitudes.Average();

                    Console.WriteLine(@"
###########################################################################
__  __ _     _ _____      _       _   _                     _
|  \/  (_)   | |  __ \    (_)     | | | |                   | |
| \  / |_  __| | |__) |__  _ _ __ | |_| |     ___   ___ __ _| |_ ___  _ __
| |\/| | |/ _` |  ___/ _ \| | '_ \| __| |    / _ \ / __/ _` | __/ _ \| '__|
| |  | | | (_| | |  | (_) | | | | | |_| |___| (_) | (_| (_| | || (_) | |
|_|  |_|_|\__,_|_|   \___/|_|_| |_|\__|______\___/ \___\__,_|\__\___/|_|
###########################################################################
                    ");
                    Console.WriteLine("Here is the midpoint latitude and longitude between all of the supplied postcodes: ");
                    Console.WriteLine(string.Join(", ", postcodes));

                    Console.WriteLine();
                    Console.WriteLine($"Midpoint Latitude: {centerLatitude}");
                    Console.WriteLine($"Midpoint Longitude: {centerLongitude}");
                    Console.WriteLine();
                    Console.WriteLine("Google Maps URL: ");
                    var googleMapURL = $"https://www.google.com/maps?q={centerLatitude},{centerLongitude}&ll={centerLatitude},{centerLongitude}&z=10";

                    Console.WriteLine(googleMapURL);
                }
                else
                {
                    Console.WriteLine("Please add valid postcodes to the assets/postcodes.txt file");
                }

                Console.WriteLine("Press enter to exit...");
                Console.ReadLine();
            }
        }

        private static async Task<Response> GetLocations()
        {
            using(var httpClient = new HttpClient())
            {
                string fullPath = System.Reflection.Assembly.GetAssembly(typeof(Program)).Location;
                string directory = Path.GetDirectoryName(fullPath);

                var filePath = $"{directory}/assets/postcodes.txt";
                var importer = new PostcodeFileImporter(filePath);
                var repo = new LocationRepository(httpClient, importer);

                return await repo.GetLocations();
            }
        }
    }
}
