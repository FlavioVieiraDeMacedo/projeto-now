using FormularioNOW.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioNOW.Models
{
    [Authorize]
    public class EngenhariaController : Controller
    {
        #region Geral
        [HttpGet]
        public ActionResult Index()
        {
            List<NOW> ListaNow = new List<NOW>();
            ListaNow = EngenhariaDAO.listar();
            return View(ListaNow);
        }

        [HttpGet]
        public ActionResult EngenhariaNOW(int Id_Now)
        {
            NOW now = NowDAO.pesquisarID(Id_Now);
            return View(now);
        }

        [HttpPost]
        public ActionResult EngenhariaNOW(NOW now)
        {
            EngenhariaDAO.CadastrarEngenharia(now);
            return RedirectToAction("Index");
        }
        #endregion
    }
}