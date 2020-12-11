﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string greetingMessage { get; set; }
        public string Time { get; set; }
        public void OnGet()
        {
            Time = DateTime.Now.ToShortTimeString();
            greetingMessage = "Hello it is currently " + Time;
        }
    }
}
