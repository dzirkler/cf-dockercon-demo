using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DZirkler.Demo.Webservice.Controllers;
using System.Net.Http;
      
namespace DZirkler.Demo.Webservice.Tests
{
    [TestClass]
	public class HelloTests
	{
		static HttpClient _httpClient = new HttpClient();
		string _baseUrl = Environment.GetEnvironmentVariable("BASE_URL");

		[TestMethod]
		public void TestHello_Get()
		{
			Console.WriteLine("Base URL: " + _baseUrl);

			var response = _httpClient.GetStringAsync(GetMethodUrl(("/api/v1/hello"))).Result;

			string expected = "Hello DockerCon!";
			string actual = response;

			Assert.AreEqual<string>(expected, actual, "GET Method did not return expected result.");
		}

		private string GetMethodUrl(string methodPartial)
		{
			return string.Format("{0}{1}", _baseUrl, methodPartial);
		}
	}
}
