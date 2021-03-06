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
            return RedirectToAction("Index");
        }
        #endregion

        [HttpGet]
        public ActionResult DetalhesNOW(int Id)
        {
            NOW Now = DAO.NowDAO.pesquisarID(Id);
            return View(Now);
        }

        [HttpGet]
        public ActionResult Pesquisar(string pesquisa)
        {
            List<NOW> ListaNow = new List<NOW>();
            if (pesquisa == null)
            {
                ListaNow = NowDAO.listar();
            }
            else
            {
                ListaNow = NowDAO.pesquisarNome(pesquisa);
            }
            return View(ListaNow);
        }

    }
}