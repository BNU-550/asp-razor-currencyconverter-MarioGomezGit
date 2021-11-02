using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorCurrencyConverter.Pages
{
    public class CurrencyConverterModel : PageModel
    {
        [BindProperty]

        public double AmountPounds { get; set; }
        public double ConversionResult { get; set; }

        private readonly ILogger<CurrencyConverterModel> _logger;

        public CurrencyConverterModel(ILogger<CurrencyConverterModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            ConversionResult = AmountPounds * 1.18;

            if (AmountPounds==0)
            {
                ViewData["Result"] = "Pounds > 0";
            }
            else
            {
                ViewData["Result"] = AmountPounds + "£ equals " + ((decimal)ConversionResult) + "€";
            }        
        }
    }
}
