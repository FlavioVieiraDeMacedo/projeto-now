using FormularioNOW.DAO;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioNOW.Controllers
{
    [Authorize]
    public class TiController : Controller
    {
        #region Geral
        [HttpGet]
        public ActionResult Index()
        {
            List<NOW> ListaNow = new List<NOW>();
            ListaNow = TiDAO.listar();
            return View(ListaNow);
        }

        [HttpGet]
        public ActionResult TiNOW(int Id_Now)
        {
            NOW now = NowDAO.pesquisarID(Id_Now);
            return View(now);
        }

        [HttpPost]
        public ActionResult TiNOW(NOW now)
        {
            TiDAO.CadastrarTi(now);
            return RedirectToAction("Index");
        }
        #endregion
        
    }
}