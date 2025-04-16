using System.Web.Mvc;

namespace Tutorial6Ex2.Controllers
{
    public class SubjectController : Controller
    {
        // GET: /Subject/
        public ActionResult Index()
        {
            return Content("This is the Subject Index page");
        }

        // GET: /Subject/subjects
        public ActionResult subjects()
        {
            return Content("This is the Subjects list page");
        }

        // GET: /Subject/Details/5
        public ActionResult Details(int id)
        {
            return Content($"This is the detail page for subject ID: {id}");
        }
    }
}
