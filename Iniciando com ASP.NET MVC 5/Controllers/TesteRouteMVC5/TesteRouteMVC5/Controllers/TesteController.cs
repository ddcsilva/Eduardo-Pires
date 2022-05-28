using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteRouteMVC5.Controllers
{
    [RoutePrefix("testes")]
    public class TesteController : Controller
    {
        [Route]
        public ActionResult Index()
        {
            return View();
        }

        [Route("um-outro-teste")]
        public ActionResult IndexTeste()
        {
            return View("Index");
        }
    }
}