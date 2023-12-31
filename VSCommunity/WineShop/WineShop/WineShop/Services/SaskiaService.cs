﻿using Newtonsoft.Json;
using System.Text;
using WineShop.Models;


namespace WineShop.Services
{
    public class SaskiaService : ISaskiaService
    {
        private Uri rutaTodos = new Uri("https://localhost:44371/api/SaskiaAlea/");
        private readonly IArdoaService _ardoaService;
        public SaskiaService(IArdoaService ardoaService)
        {
            _ardoaService = ardoaService;
        }
        public async Task SaskiaGehitu(int ardoaId, string saskiaId)
        {
            //Saskia existitzen den begiratu
            Uri rutasaskia = new Uri(rutaTodos, saskiaId);
            List<SaskiaAlea> saskiaAleaList = new List<SaskiaAlea>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutasaskia))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    saskiaAleaList = JsonConvert.DeserializeObject<List<SaskiaAlea>>(apiResponse);
                }
            }
            SaskiaAlea cartitem = new SaskiaAlea();
            cartitem = null;
            if (saskiaAleaList != null)
            {

                cartitem = saskiaAleaList.FirstOrDefault(s => s.ArdoaId == ardoaId);
            }
            if (saskiaAleaList == null || cartitem == null)
            {
                // Karrito berria sortu
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(new SaskiaAlea
                    {
                        ArdoaId = ardoaId,
                        SaskiaId = saskiaId,
                        Kantitatea = 1,
                        Data = DateTime.Now
                    }), Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(rutaTodos, content);
                    response.EnsureSuccessStatusCode();
                    
                }
               
            }
            else
            {
                cartitem.Kantitatea++;
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(cartitem), Encoding.UTF8, "application/json");
                    var response = await httpClient.PutAsync(rutasaskia, content);
                    response.EnsureSuccessStatusCode();
                }
            }
        }

        public async Task<List<SaskiaAlea>> SaskiaLortuAleak(string saskiaId)
        {
            //Saskia lortu
            Uri rutasaskia = new Uri(rutaTodos, saskiaId);
            List<SaskiaAlea> saskiaAleaList = new List<SaskiaAlea>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutasaskia))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    saskiaAleaList = JsonConvert.DeserializeObject<List<SaskiaAlea>>(apiResponse);
                }
            }
            return saskiaAleaList;
        }
    }
}
