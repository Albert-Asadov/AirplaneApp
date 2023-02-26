using System;
using AirplaneApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirplaneApp.Controllers
{
	public class CotegoryController:Controller
	{
		public List<Cotergory> cot;

		public CotegoryController()
		{
			cot = new List<Cotergory>()
			{
                new Cotergory()
                {
                    Id = 1,
                    Name = "CARGO"
                },
                 new Cotergory()
                {
                     Id= 2,
                    Name = "Сivil Aviation"
                }
            };

        }

		public ActionResult item()
		{


			return View(cot);
		}
	}
}

