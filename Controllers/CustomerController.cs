using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using prjCoreDemo.Models;
using prjCoreDemo.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prjCoreDemo.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var customers = _db.TCustomer.ToList();
            return View(customers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TCustomer customer)
        {
            _db.TCustomer.Add(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var customer = _db.TCustomer.Where(m => m.FId == id).FirstOrDefault();
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(TCustomer customer)
        {
            var modify = _db.TCustomer.Where(m => m.FId == customer.FId).FirstOrDefault();
            modify.FName = customer.FName;
            modify.FPhone = customer.FPhone;
            modify.FEmail = customer.FEmail;
            modify.FAddress = customer.FAddress;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var customer = _db.TCustomer.Where(m => m.FId == id).FirstOrDefault();
            _db.TCustomer.Remove(customer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

