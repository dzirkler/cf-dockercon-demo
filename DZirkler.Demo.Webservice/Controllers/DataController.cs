using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DZirkler.Demo.Webservice.Controllers
{
	[Route("api/v1/[controller]")]
	public class DataController : Controller
	{
		// GET api/hello
		[HttpGet]
		public List<string> Get()
		{
			string filecontents = System.IO.File.ReadAllText("/data_files/data.txt");
			List<string> items = new List<string>(filecontents.Split("\n".ToCharArray()));

			return items;
		}

	}
}