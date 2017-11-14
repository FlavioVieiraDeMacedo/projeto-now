using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioNOW.DAO
{
    [Authorize]
    public class QualidadeController : Controller
    {
        #region Geral
        [HttpGet]
        public ActionResult Index()
        {
            List<NOW> ListaNow = new List<NOW>();
            ListaNow = QualidadeDAO.listar();
            return View(ListaNow);
        }

        [HttpGet]
        public ActionResult QualidadeNOW(int Id_Now)
        {
            NOW now = NowDAO.pesquisarID(Id_Now);
            return View(now);
        }

        [HttpPost]
        public ActionResult QualidadeNOW(NOW now)
        {
           QualidadeDAO.CadastrarQualidade(now);
            return RedirectToAction("Index");
        }
        #endregion
    }
}