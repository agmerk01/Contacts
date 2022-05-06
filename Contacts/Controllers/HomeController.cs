using ContactList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ContactList.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext Context { get; set; }
        public HomeController(ContactContext ctx)
        {
            Context = ctx;
        }
        public IActionResult Index()
        {
            var contacts = Context.Contacts.Include(m => m.Category).OrderBy(c => c.LName).ToList();
            return View(contacts);
        }
    }
}