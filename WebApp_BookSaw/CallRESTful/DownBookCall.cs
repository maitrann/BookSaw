using API_BookSaw.Entities;
using API_BookSaw.ModelsView;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Headers;
using WebApp_BookSaw.BaseURL;

namespace WebApp_BookSaw.CallRESTful
{
    public class DownBookCall
    {
        DownBookCall() { }
        private static DownBookCall instance = null;
        public static DownBookCall Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DownBookCall();
                }
                return instance;
            }
        }
        public bool DownBookToLib(DownBook model)
        {
            bool prodInfo = false;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = client.PostAsJsonAsync(DownBookURL.DownBookToLib, model).GetAwaiter().GetResult();
                if (Res.IsSuccessStatusCode)
                {
                    var prodResponse = Res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    prodInfo = JsonConvert.DeserializeObject<bool>(prodResponse);
                }
                return prodInfo;
            }
        }
        public List<DownBookView> GetDownBookViews(int idClient)
        {
            List<DownBookView> prodInfo = new List<DownBookView>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = client.GetAsync(DownBookURL.GetDownBookViews+"/"+idClient).GetAwaiter().GetResult();
                if (Res.IsSuccessStatusCode)
                {
                    var prodResponse = Res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    prodInfo = JsonConvert.DeserializeObject<List<DownBookView>>(prodResponse);
                }
                return prodInfo;
            }
        }
    }
}
