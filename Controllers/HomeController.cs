﻿using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
	public class HomeController : Controller

	{ 
		private static PersonRepository db = new PersonRepository();
		public ViewResult Index()
		{

			int hour = DateTime.Now.Hour;
			ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
			ViewData["Mes"] = "good mood!";
			return View();
		}

		[HttpGet]
		public ViewResult InputData()
		{
			return View();
		}
		[HttpPost]
		public ViewResult InputData(Person person)
		{
			db.AddResponse(person);
			return View("Hello", person);

		}

		public ViewResult OutputData()
			{
				ViewBag.Pers = db.GetAllResponses;
				ViewBag.Count = db.NumberOfPerson;
				return View("ListPerson");
			}

		}
}
