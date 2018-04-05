using Microsoft.AspNetCore.Mvc;
using System;

namespace LogIt.Web.Controllers
{

	public class LogController : Controller
	{
		public IActionResult Home()
		{
			return View();
		}

		public IActionResult ViewLog(int id){
			return View();
		}
	}
}