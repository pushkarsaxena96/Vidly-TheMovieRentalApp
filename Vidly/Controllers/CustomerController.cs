using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Controllers.ViewModels;
using Vidly.Models;
//using Vidly.ViewModels;
using System.Data.Entity;


namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext(); // Initilizing ApplicationDbContext in constructor
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult New()
        {
            return View();
        }

        // GET: Customer
        public ViewResult Index()
        {
            //var viewModel = GetCustomers();
            var viewModel = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(viewModel);
        }

        public ViewResult Details(int Id = 1)
        {

            //var viewDetail = GetCustomers().SingleOrDefault(c => c.ID == Id);
            var viewDetail = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.ID == Id);
            return View(viewDetail);
        }


        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer { ID =1,Name = "John Cena"},
        //        new Customer { ID =2,Name = "Mary Williams"}
        //    };
        //}
        

    }
}