using PersonalApplication.DAO;
using PersonalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String login, String senha)
        {
            UsuarioDao dao = new UsuarioDao();
            Usuario usuario = dao.Busca(login, senha);

            if(usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("index", "despesa");
            }
            else
            {
                return RedirectToAction("index");
            }
        }
    }
}