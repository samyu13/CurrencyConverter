using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Models
{
    public class CurrencyConversion
    {

        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }

        public string ConvertFrom = "GBP";

        [Required]
        public string ConvertTo { get; set; }

        public decimal ConvertedAmount { get; set; }

        public List<SelectListItem> Countries()
        {
            return new List<SelectListItem> {

                new SelectListItem { Value = "USD", Text = "USD" },
                new SelectListItem { Value = "AUD", Text = "AUD"  },
                new SelectListItem { Value = "EUR", Text = "EUR"  }
            };
        }
    }
}
