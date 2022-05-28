using System.Web.Mvc;

namespace TesteActionMVC5.Controllers
{
    public class HomeController : Controller
    {
        // Retorna uma View
        public ViewResult Index()
        {
            return View();
        }

        // Retorna um conteúdo em String
        public ContentResult ContentResult()
        {
            return Content("Olá!");
        }

        // Retorna um array de bytes para realizar o download de um arquivo
        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/google.png"));

            return File(foto, "image/png", "google.png");
        }

        // Retorna um resultado de Não Autorizado (Erro 403)
        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }

        // Retorna um JSON
        public JsonResult JsonResult()
        {
            // Por default, não é permitido o Get em JSON, por isso precisamos permitir com o segundo atributo
            return Json("teste: 'Teste'", JsonRequestBehavior.AllowGet);
        }

        // Redireciona para a URL desejada
        public RedirectResult RedirectResult()
        {
            return new RedirectResult("https://www.uol.com.br");
        }

        // Redireciona para uma Rota específica, a partir de uma Controller e uma Action
        public RedirectToRouteResult RedirectToRouteResult()
        {
            return RedirectToRoute(new 
            { 
                controller = "Home",
                action = "Index"
            });
        }

        // Redireciona para uma action da própria Controller ou para outra se informada no segundo parâmetro
        public RedirectToRouteResult RedirectToAction()
        {
            return RedirectToAction("Index", "Teste");
        }
    }
}