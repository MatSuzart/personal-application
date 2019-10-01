using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalApplication.DAO;
using PersonalApplication.Models;

namespace PersonalApplication.Controllers
{
    public class RendaController : Controller
    {
        // GET: Renda
        public ActionResult Index()
        {
            RendaDao dao = new RendaDao();
            IList<Renda> rendas = dao.Lista();
            ViewBag.Rendas = rendas;
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Renda renda)
        {
            RendaDao dao = new RendaDao();
            dao.Adiciona(renda);

            return RedirectToAction("index", "Renda");
        }
    }
}