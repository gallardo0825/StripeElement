using System.Diagnostics;
using Logintest.Models;
using Logintest.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Stripe;


namespace Logintest.Controllers
{
    /*[Route("create-payment-intent")]
    [ApiController]*/
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext AppDb;
        private readonly ILogger<HomeController> _logger;

        public HomeController (ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /*[HttpPost]
        public ActionResult Get()
        {
            StripeConfiguration.ApiKey = "sk_test_51LvqPVCgb8glDeFebFAlVXi7JxsdJGI7ORKqEEdGyJYJrnqKX1Hdnh7DwTFPbkJDzSCvDgUyffjFQk4tlzcOEHGS00tTtrhwFA";
            var options = new PaymentIntentCreateOptions
            {
                Amount = 10,
                Currency = "jpy",
                AutomaticPaymentMethods = new PaymentIntentAutomaticPaymentMethodsOptions
                {
                    Enabled = true,
                },
            };
            var service = new PaymentIntentService();
            var paymentIntent = service.Create(options);//Fetch関数使う？
            return Json(new { clientSecret = paymentIntent.ClientSecret });
        }*/

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}