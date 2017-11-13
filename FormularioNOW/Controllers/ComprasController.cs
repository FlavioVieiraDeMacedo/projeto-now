using FormularioNOW.DAO;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioNOW.Controllers
{
    public class ComprasController : Controller
    {
        #region Geral
        [HttpGet]
        public ActionResult Index()
        {
            List<NOW> ListaNow = new List<NOW>();
            ListaNow = ComprasDAO.listar();
            return View(ListaNow);
        }

        [HttpGet]
        public ActionResult ComprasNOW(int Id_Now)
        {
            NOW now = NowDAO.pesquisarID(Id_Now);
            return View(now);
        }

        [HttpPost]
        public ActionResult ComprasNOW(NOW now)
        {
            ComprasDAO.CadastrarCompras(now);
            return RedirectToAction("Index");
        }
        #endregion
    }
}