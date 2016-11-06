using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_one.Models;
using Vidly_one.ViewModels;

namespace Vidly_one.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Customer
        public ActionResult Index()
        {
            var cus = _context.Customers.Include(c => c.MemberShipType).ToList();
            var viewModel = new CustomerIndexViewModel()
            {
                Customers = cus
            };
            return View(viewModel);
        }
    //   [Route("customer/DetailsName/{name}")]
        public ActionResult DetailsName(string name)
        {
          var customer = _context.Customers.Include(c=> c.MemberShipType).SingleOrDefault(c=> c.Name == name);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MemberShipTypes.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                MemberShipTypes = membershipTypes

            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)

        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel()
            {
                Customer =  customer,
                MemberShipTypes = _context.MemberShipTypes.ToList()
            };
            return View("CustomerForm",viewModel);
        }
    }
}