using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DZirkler.Demo.Webservice.Controllers;

namespace DZirkler.Demo.Webservice.Tests
{
	[TestClass]
	public class DataTests
	{
		DataController _controller = new DataController();

		[TestMethod]
		public void TestDataGet_Count()
		{

			int expected = 2;
			int actual = _controller.Get().Count;

			Assert.AreEqual<int>(expected, actual, "GET Method did not return expected number of results.");
		}

		[DataRow(0, "This is a data line.")]
		[DataRow(1, "Another bit of data.")]
		[DataTestMethod]
		public void TestDataGet_Values(int index, string expected)
		{
			string actual = _controller.Get()[index];

			Assert.AreEqual<string>(expected, actual, string.Format("GET Method did not return expected result for index {0}.", index));
		}

	}
}
