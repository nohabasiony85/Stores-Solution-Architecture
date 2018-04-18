using Stores.Service;
using System.Web.Mvc;

namespace Stores.Web.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerService customerService;

        // GET: Customer
        public ActionResult Index()
        {
            return View(customerService.GetCustomers());
        }
    }
}