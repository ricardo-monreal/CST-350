﻿using ButtonGrid.Models;
using Microsoft.AspNetCore.Mvc;

namespace ButtonGrid.Controllers
{
    public class ButtonController : Controller
    {

        static List<ButtonModel> buttons = new List<ButtonModel>();
        Random random = new Random();

        const int GRID_SIZE = 25;

        public IActionResult Index()
        {
            if (buttons.Count < GRID_SIZE)
            {
                for (int i = 0; i < GRID_SIZE; i++)
                {
                    buttons.Add(new ButtonModel { Id = i, ButtonState = random.Next(4) });
                }
                
            }
            return View("Index", buttons);

        }


        public IActionResult HandleButtonClick(string buttonNumber)
        {
            // convert from string to int
            int bn = int.Parse(buttonNumber);

            buttons.ElementAt(bn).ButtonState = (buttons.ElementAt(bn).ButtonState + 1) % 4;

            return View("Index", buttons);
        }

        public IActionResult ShowOneButton(int buttonNumber)
        {
            // add one to the button state. if > 4, then reset to 0
            buttons.ElementAt(buttonNumber).ButtonState = (buttons.ElementAt(buttonNumber).ButtonState + 1) % 4;

            return PartialView(buttons.ElementAt(buttonNumber));
        }



    }
}
