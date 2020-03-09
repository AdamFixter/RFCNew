using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        private User fetchUser(string Name, string DomainUser)
        {
            User User = _context.User.FirstOrDefault(user => user.Name == Name && user.DomainUser == DomainUser);
            if (User == null)
            {
                User = new User() { Name = Name, DomainUser = DomainUser, Role = UserRole.Standard };
                _context.User.Add(User);
                _context.SaveChangesAsync();
            }
            return User;
        }
        public IActionResult Index()
        {
            var args = User.Identity.Name.Split("\\");
            var textInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
            var Name = textInfo.ToTitleCase(args[1].Replace(".", " "));
            var DomainUser = User.Identity.Name;

            var fetchedUser = this.fetchUser(Name, DomainUser);
            return View(fetchedUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
