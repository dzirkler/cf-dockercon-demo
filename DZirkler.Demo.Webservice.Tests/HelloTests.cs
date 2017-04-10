using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DZirkler.Demo.Webservice.Controllers;

namespace DZirkler.Demo.Webservice.Tests
{
    [TestClass]
	public class HelloTests
	{
		HelloController _controller = new HelloController();

		[TestMethod]
		public void TestHelloGet()
		{

			string expected = "Hello World!";
			string actual = _controller.Get();

			Assert.AreEqual<string>(expected, actual, "GET Method did not return expected result.");
		}

	}
}
