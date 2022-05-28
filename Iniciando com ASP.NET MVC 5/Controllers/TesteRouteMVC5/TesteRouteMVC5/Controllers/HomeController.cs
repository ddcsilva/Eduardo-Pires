using System.Web.Mvc;

namespace TesteRouteMVC5.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [Route("sobre-nos")]
        public ActionResult About()
        {
            return View();
        }

        [Route("institucional/entre-em-contato")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("content-result")]
        public ContentResult ContentResult()
        {
            return Content("Olá!");
        }

        [Route("downloads/meu-arquivo")]
        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/google.png"));

            return File(foto, "image/png", "google.png");
        }

        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }

        public JsonResult JsonResult()
        {
            return Json("teste: 'Teste'", JsonRequestBehavior.AllowGet);
        }

        public RedirectResult RedirectResult()
        {
            return new RedirectResult("https://www.uol.com.br");
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            return RedirectToRoute(new
            {
                controller = "Home",
                action = "Index"
            });
        }

        public RedirectToRouteResult RedirectToAction()
        {
            return RedirectToAction("Index", "Teste");
        }
    }
}