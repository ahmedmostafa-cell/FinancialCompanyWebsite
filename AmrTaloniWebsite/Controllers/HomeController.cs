using AmrTaloniWebsite.BL;
using AmrTaloniWebsite.Models;
using EmailService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmrTaloniWebsite.Controllers
{
    public class HomeController : Controller
    {
        companyImageService compamyService;
        AmrTaloniDatabaseContext ctx;
        IEmailSender _emailSender;
       
        public HomeController(companyImageService Compamyservice, AmrTaloniDatabaseContext context , IEmailSender emailSender)
        {
            compamyService = Compamyservice;
            ctx = context;
            _emailSender = emailSender;

        }
      
       

        public async Task<IActionResult> IndexAsync(string name, string email, string content , IFormCollection form, IFormFileCollection files, string phone , string HotelName, DateTime checkin, DateTime checkout, string noofrooms, string roomtype, string noofadults, string car)
        {
            HomePageModel model = new HomePageModel();
            model.lstItems = compamyService.getAll();
            try
            {
                if (name != null)
                {
                    var userEmail = email;

                    //var messages = new Message(new string[] { "ahmedmostafa706@gmail.com"}, "Email From Customer " + "His name is " + name + "\n" + " His Email Is " + email + "\n" + " His phone is " + phone + "\n" + "He needs to book " + "hotel name " +  HotelName + "\n" + "Check in date " +  " " + checkin + "\n" + "Check out date" + " " + checkout + "\n" + "No of rooms " + noofrooms + "\n" + "Room type " + roomtype + "\n" + "No of guests " + noofadults + "\n" + "H needs a car " + car, "This is the content from our async email. i am happy", files);
                    var messages = new Message(new string[] { "ahmedmostafa706@gmail.com" }, "Email From Customer " + "His name is " + name + "\n" + " His Email Is " + email + "\n" , "This is the content from our async email. i am happy", files);
                    //var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads", ImageName);
                    //var files = Request.Form.Files.Any() ? Request.Form.Files : new FormFileCollection();
                    await _emailSender.SendEmailAsync(messages, content);
                    //_notyf.Success("The Message Has Been Sent");
                    return View(model);
                }
                else
                {
                    return View(model);
                }

            }
            catch (Exception ex)
            {
                ViewBag.ex = ex;
                return View(model);

            }


        }
    }
}
