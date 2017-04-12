using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DZirkler.Demo.Webservice.Controllers;
using System.Net.Http;

namespace DZirkler.Demo.Webservice.Tests
{
	[TestClass]
	public class DataTests
	{
		static HttpClient _httpClient = new HttpClient();
		string _baseUrl = Environment.GetEnvironmentVariable("BASE_URL");

		[TestMethod]
		public void TestDataGet()
		{

			var response = _httpClient.GetStringAsync(GetMethodUrl(("/api/v1/data"))).Result;

			string expected = "[\"This is a data line.\",\"Another bit of data.\"]";
			string actual = response;

			Assert.AreEqual<string>(expected, actual, "GET Method did not return expected results.");
		}

		private string GetMethodUrl(string methodPartial)
		{
			return string.Format("{0}{1}", _baseUrl, methodPartial);
		}

	}
}
