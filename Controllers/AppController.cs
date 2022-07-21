﻿using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;


        public AppController(IMailService mailService)
        {
            _mailService = mailService;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
           

            return View();
        }

        // [RequestType(URL pattern)]
        // The models use the Class from ViewModels
        // to map each field for each prop using the name
        // and is case sensitive
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send email
                _mailService.SendMessage("ccc@xxx.com", model.Subject, $"From: {model.Name} - { model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            
            }
            else
            {
                // Show error
            }
            
            return View();
        }


        public IActionResult About()
        {
            ViewBag.Title = "About us";
            return View();
        }
    }

    
}
