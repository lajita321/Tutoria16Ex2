using System.Web.Mvc;

namespace Tutorial6Ex2.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return Content("Welcome to the Student home page!");
        }
    }
}
