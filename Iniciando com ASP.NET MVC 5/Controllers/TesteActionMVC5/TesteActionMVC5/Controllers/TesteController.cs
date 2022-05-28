using System.Web.Mvc;

namespace TesteActionMVC5.Controllers
{
    public class TesteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}