using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DZirkler.Demo.Webservice.Controllers
{
	[Route("api/v1/[controller]")]
	public class HelloController : Controller
	{
		// GET api/hello
		[HttpGet]
		public string Get()
		{
			return "Hello World!";
		}

	}
}