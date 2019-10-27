using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace kata_config.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly IOptions<MyConfig> Config;

        public IndexModel(ILogger<IndexModel> logger, IOptions<MyConfig> config)
        {
            _logger = logger;
            Config = config;
        }

        public void OnGet()
        {
            
        }
    }
}
