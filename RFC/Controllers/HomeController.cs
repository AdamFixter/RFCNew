using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RFC.Models;
using RFC.ViewModel;

namespace RFC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RFCContext _context;

        public HomeController(ILogger<HomeController> logger, RFCContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var args = User.Identity.Name.Split("\\");
            var textInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
            var Name = textInfo.ToTitleCase(args[1].Replace(".", " "));
            var DomainUser = User.Identity.Name;

            var role = "Standard";
            Debug.WriteLine($"\n\n{Name}\n{DomainUser}\n");
                _context.Database.ExecuteSqlRaw(
                    $"BEGIN IF NOT EXISTS " +
                        $"(SELECT * FROM [dbo].[User] WHERE Name='{Name}' AND DomainUser='{DomainUser}')" +
                            $"BEGIN INSERT INTO [dbo].[User] (Name, Role, DomainUser)" +
                                $"VALUES ('{Name}', '{role}', '{DomainUser}')" +
                            $"END" +
                   $" END");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
