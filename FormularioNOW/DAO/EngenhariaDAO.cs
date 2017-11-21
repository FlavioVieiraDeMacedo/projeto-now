using FormularioNOW.Context;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioNOW.DAO
{
    public static class EngenhariaDAO
    {
        #region Cadastrar ENGENHARIA
        public static void CadastrarEngenharia(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Find(now.ID_now).Engenharia = now.Engenharia;
                ctx.Now.Find(now.ID_now).NecessitaNovaMaquina = now.NecessitaNovaMaquina;
                ctx.Now.Find(now.ID_now).DescricaoMaquina = now.DescricaoMaquina;
                ctx.Now.Find(now.ID_now).Engenharia_status = true;
                ctx.SaveChanges();
            }
        }
        #endregion

        #region Listar
        public static List<NOW> listar()
        {
            try
            {
                using (var ctx = new NowContext())
                {
                    return ctx.Now.Where(a=>a.Engenharia_status==false && a.Produto_status == true).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            };
        }
        #endregion
    }
}