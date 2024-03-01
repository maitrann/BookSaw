using API_BookSaw.Entities;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebApp_BookSaw.BaseURL;

namespace WebApp_BookSaw.CallRESTful
{
	public class BookCall
	{
		BookCall() { }
		private static BookCall instance = null;
		public static BookCall Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new BookCall();
				}
				return instance;
			}
		}
		public List<Book> GetBooks()
		{
			List<Book> prodInfo = new List<Book>();
			using (var client = new HttpClient())
			{
				client.DefaultRequestHeaders.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				HttpResponseMessage Res = client.GetAsync(BookURL.GetBooks).GetAwaiter().GetResult();
				if (Res.IsSuccessStatusCode)
				{
					var prodResponse = Res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
					prodInfo = JsonConvert.DeserializeObject<List<Book>>(prodResponse);
				}
				return prodInfo;
			}
		}
		public List<Book> GetNewBooks()
		{
			List<Book> prodInfo = new List<Book>();
			using (var client = new HttpClient())
			{
				client.DefaultRequestHeaders.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				HttpResponseMessage Res = client.GetAsync(BookURL.GetNewBooks).GetAwaiter().GetResult();
				if (Res.IsSuccessStatusCode)
				{
					var prodResponse = Res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
					prodInfo = JsonConvert.DeserializeObject<List<Book>>(prodResponse);
				}
				return prodInfo;
			}
		}
		public List<Book> GetBooksByCate(int idCate)
		{
			List<Book> prodInfo = new List<Book>();
			using (var client = new HttpClient())
			{
				client.DefaultRequestHeaders.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				HttpResponseMessage Res = client.GetAsync(BookURL.GetBooksByCate + "/" + idCate).GetAwaiter().GetResult();
				if (Res.IsSuccessStatusCode)
				{
					var prodResponse = Res.Content.ReadAsStringAsync().GetAwaiter().GetResult();
					prodInfo = JsonConvert.DeserializeObject<List<Book>>(prodResponse);
				}
				return prodInfo;
			}
		}
	}
}
