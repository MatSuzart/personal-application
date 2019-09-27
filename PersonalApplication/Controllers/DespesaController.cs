using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalApplication.DAO;
using PersonalApplication.Models;

namespace PersonalApplication.Controllers
{
    [Route("despesas", Name ="ListaDespesas")]
    public class DespesaController : Controller
    {
        // GET: Despesa
        public ActionResult Index()
        {
            DespesaDao dao = new DespesaDao();
            IList<Despesa> despesas = dao.Lista();
            ViewBag.Despesas = despesas;
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(String nome, double valor, String data)
        {
            if (ModelState.IsValid)
            {

                Despesa despesa = new Despesa()
                {
                    Nome = nome,
                    Valor = valor,
                    Data = data,
                };

                DespesaDao dao = new DespesaDao();
                dao.Adiciona(despesa);

                return RedirectToAction("index", "Despesa");
            }
            else
            {
                return View("Form");
            }
        }
        [Route("despesas/{id}", Name ="VisualizaDespesa")]
        public ActionResult Visualiza(int id)
        {
            DespesaDao dao = new DespesaDao();
            Despesa despesa = dao.BuscaPorId(id);
            ViewBag.Despesa = despesa;
            return View();
        }
       
    }

}