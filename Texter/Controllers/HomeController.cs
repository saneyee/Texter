using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Texter.Models;

namespace Texter.Controllers
{
    public class HomeController : Controller
    {

        private TexterDbContext db = new TexterDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }



        public IActionResult Error()
        {
            return View();
        }

        public IActionResult GetMessages()
        {
            var allMessages = Message.GetMessages();
            return View(allMessages);
        }

        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message newMessage)
        {
            newMessage.Send();
            return RedirectToAction("Index");
        }

        public IActionResult NewContact()
        {
            ViewBag.Contacts = db.Contacts.ToList();
            return View(ViewBag.Contacts);
        }

       
        [HttpPost]
        public IActionResult NewContact(string newName, string newPhone)
        {
            Contact newContact = new Contact(newName, newPhone);
            db.Contacts.Add(newContact);
            db.SaveChanges();
            return Json(newContact);
        }
    }
}
