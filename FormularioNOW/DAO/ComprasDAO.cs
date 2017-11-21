using FormularioNOW.Context;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioNOW.DAO
{
    public static class ComprasDAO
    {
        #region Cadastrar COMPRAS
        public static void CadastrarCompras(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Find(now.ID_now).Compras = now.Compras;
                ctx.Now.Find(now.ID_now).Compras_status = true;
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
                    return ctx.Now.Where(a => a.Compras_status == false && a.TI_status == true && a.Engenharia_status == true && a.Produto_status==true).ToList();
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