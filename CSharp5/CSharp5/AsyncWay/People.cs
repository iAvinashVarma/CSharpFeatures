using CSharp5.AsyncWay.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharp5.AsyncWay
{
	public class People
	{
		public async Task<IEnumerable<Person>> GetPeopleAsync()
		{
			const string uriString = "http://localhost:49236/";
			var client = new HttpClient();
			var address = new Uri(uriString);
			client.BaseAddress = address;

			var response = await client.GetAsync("api/Biometric");

			if(response.IsSuccessStatusCode)
			{
				var list = await response.Content.ReadAsAsync<IEnumerable<Person>>();
				return list;
			}
			else
			{
				return null;
			}
		}
	}
}
