using System;
using AirplaneApp.Models;
using AirplaneApp.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AirplaneApp.Controllers
{
	public class HomeController:Controller
	{
        public List<Airplane> air;
        public List<Cotergory> coteg;

		public HomeController()
		{
            coteg = new List<Cotergory>()
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

			air = new List<Airplane>()
			{
				new Airplane()
				{
					Id = 1,
					Photo = "https://www.azal.az/media/2022/04/28/319_1.jpg",
					Model = "Airbus A320-200",
					Discription = "More fuel-efficient, direct and on-time flights and better-maintained aircraft with Honeywell solutions for the Airbus A320."
                },
                new Airplane()
                {
                    Id = 2,
                    Photo = "https://www.azal.az/media/2022/04/28/319_2.jpg",
                    Model = "Airbus A319-111",
                    Discription = "More fuel-efficient, direct and on-time flights and better-maintained aircraft with Honeywell solutions for the Airbus A319."
                },
                new Airplane()
                {
                    Id = 3,
                    Photo = "https://cdn.jetphotos.com/full/6/41171_1563043229.jpg",
                    Model = "Boeing 757-200",
                    Discription = "More fuel-efficient, direct and on-time flights and better-maintained aircraft with Honeywell solutions for the Boeing 757."
                },
                new Airplane()
                {
                    Id = 4,
                    Photo = "https://www.azal.az/media/2022/04/28/767_1.jpg",
                    Model = "Boeing 767-32LR",
                    Discription = "More fuel-efficient, direct and on-time flights and better-maintained aircraft with Honeywell solutions for the Boeing 767-32LR."
                },
                 new Airplane()
                {
                    Id = 5,
                    Photo = "https://www.azal.az/media/2022/04/28/787_1.jpg",
                    Model = "Boeing 787-8 DreamLiner",
                    Discription = "More fuel-efficient, direct and on-time flights and better-maintained aircraft with Honeywell solutions for the Boeing 787-8 DreamLiner."
                },
                 new Airplane()
                {
                    Id = 6,
                    Photo = "https://www.azal.az/media/2022/04/28/340_2.jpg",
                    Model = "Airbus A340-500",
                    Discription = "More fuel-efficient, direct and on-time flights and better-maintained aircraft with Honeywell solutions for the Airbus A340-50."
                },
                 new Airplane()
                {
                    Id = 7,
                    Photo = "https://upload.wikimedia.org/wikipedia/commons/5/59/Boeing_747-4R7F%28SCD%29%2C_Silk_Way_West_Airlines_JP7696736.jpg",
                    Model = "Boeing 747-8 SW",
                    Discription = "More fuel-efficient, direct and on-time flights and better-maintained aircraft with Honeywell solutions for the Boeng 747-8."
                },
                 new Airplane()
                {
                    Id = 8,
                    Photo = "https://upload.wikimedia.org/wikipedia/commons/b/b2/Silk_Way_Airlines_Il-76TD_4K-AZ55_FRU_May_2007.png",
                    Model = "Il - 76 SW",
                    Discription = "More fuel-efficient, direct and on-time flights and better-maintained aircraft with Honeywell solutions for the Il-76."
                }
            };
		}

        public ActionResult about()
		{
            HomeVM model = new HomeVM()
            {
                air = air,
                coteg = coteg
            };
			return View(model);
		}
		
	}
}

