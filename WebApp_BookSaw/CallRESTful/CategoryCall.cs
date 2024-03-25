using RestAPI_BookSaw.Entities;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebApp_BookSaw.BaseURL;

namespace WebApp_BookSaw.CallRESTful
{
    public class CategoryCall
    {
        CategoryCall() { }
        private static CategoryCall instance = null;
        public static CategoryCall Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryCall();
                }
                return instance;
            }
        }
        public List<Category> GetSomeCategoryAndBooks()
        {
            List<Category> prodInfo = new List<Category>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = client.GetAsync(CategoryURL.GetSomeCategoryAndBooks).GetAwaiter().GetResult();
                if (Res.IsSuccessStatusCode)
                {
                    var prodResponse = Res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    prodInfo = JsonConvert.DeserializeObject<List<Category>>(prodResponse);
                }
                return prodInfo;
            }
        }

    }
}
