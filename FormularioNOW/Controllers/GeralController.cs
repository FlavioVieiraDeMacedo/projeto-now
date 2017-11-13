using FormularioNOW.DAO;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioNOW.Controllers
{
    public class GeralController : Controller
    {

        #region Geral
        [HttpGet]
        public ActionResult Index()
        {
            List<NOW> ListaNow = new List<NOW>();
            ListaNow = NowDAO.listar();
            return View(ListaNow);
        }
        
        [HttpGet]
        public ActionResult GerarNOW()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GerarNOW(NOW now)
        {
            DAO.NowDAO.Cadastrar(now);
            return View();
        }
        #endregion


        [HttpGet]
        public ActionResult DetalhesNOW(int Id)
        {
            NOW Now = DAO.NowDAO.pesquisarID(Id);
            return View(Now);
        }

    }
}