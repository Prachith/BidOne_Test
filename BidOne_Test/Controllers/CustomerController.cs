using BidOne_Test.Models;
using BidOne_Test.Service;
using Microsoft.AspNetCore.Mvc;

namespace BidOne_Test.Controllers
{
    public class CustomerController : Controller
    {
        readonly ICustomerBL _customerBL;
        public CustomerController(ICustomerBL customerBL)
        {
            _customerBL = customerBL;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Customers customers)
        {
            var result = _customerBL.AddData(customers);

            return View("Index");
        }
    }
}
