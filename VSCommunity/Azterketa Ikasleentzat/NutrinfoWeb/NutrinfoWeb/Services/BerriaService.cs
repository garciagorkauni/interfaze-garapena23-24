using Newtonsoft.Json;
using NutrinfoWeb.Models;
using System.Text;

namespace NutrinfoWeb.Services
{
    public class BerriaService : IBerriaService
    {
        public async Task<Berria> BerriaSortu(Berria berria)
        {
            Uri rutaBerria = new Uri("https://localhost:7098/api/Berria");

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(berria), Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(rutaBerria, content);
                response.EnsureSuccessStatusCode();

                return berria;
            }
        }
    }
}
