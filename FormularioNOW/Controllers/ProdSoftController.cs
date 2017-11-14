﻿using FormularioNOW.DAO;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioNOW.Controllers
{
    [Authorize]
    public class ProdSoftController : Controller
    {
        #region Geral
        [HttpGet]
        public ActionResult Index()
        {
            List<NOW> ListaNow = new List<NOW>();
            ListaNow = ProdSoftDAO.listar();
            return View(ListaNow);
        }

        [HttpGet]
        public ActionResult ProdSoftNOW(int Id_Now)
        {
            NOW now = NowDAO.pesquisarID(Id_Now);
            return View(now);
        }

        [HttpPost]
        public ActionResult ProdSoftNOW(NOW now)
        {
            ProdSoftDAO.CadastrarProdSoft(now);
            return RedirectToAction("Index");
        }
        #endregion
    }
}