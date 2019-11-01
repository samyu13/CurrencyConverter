using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyConverter.Models;
using CurrencyConverter.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    [Route("/")]
    public class CurrencyConverterController : Controller
    {
        private readonly ICurrencyConverter currencyConverter;

        public CurrencyConverterController(ICurrencyConverter currencyConverter)
        {
            this.currencyConverter = currencyConverter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CurrencyConversion converter = new CurrencyConversion();
            return View(converter);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Convert(CurrencyConversion model)
        {
            model.ConvertedAmount = currencyConverter.convert(model.ConvertTo, model.Amount);
            return View("Index", model);
        }
    }
}