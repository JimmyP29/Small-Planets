using SmallPlanets.Interfaces;
using SmallPlanets.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmallPlanets.Services
{
    public class APIConsumerService : IAPIConsumer
    {
        static HttpClient client = new HttpClient();



        public SolarSystem GetSolarSystem()
        {
            Task<SolarSystem> task = GetSolarSystemAsync();
            SolarSystem solarSystem = task.Result; 
            return solarSystem;
        }

        static async Task<SolarSystem> GetSolarSystemAsync()
        {
            SolarSystem solarSystem = null;
            try
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:4659/api/solarsystem").Result;

                if (response.IsSuccessStatusCode)
                {
                    solarSystem = await response.Content.ReadAsAsync<SolarSystem>();
                }
            }
            catch (Exception e)
            {

                throw;
            }
        

            return solarSystem;
        }
    }
}