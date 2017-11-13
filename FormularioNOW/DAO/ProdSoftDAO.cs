using FormularioNOW.Context;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioNOW.DAO
{
    public class ProdSoftDAO
    {
        #region Cadastrar ProdSoft
        public static void CadastrarProdSoft(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Find(now.ID_now).ProdSoft = now.ProdSoft;
                ctx.Now.Find(now.ID_now).ProdSoft_status = true;
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
                    return ctx.Now.Where(a => a.ProdSoft_status == false).ToList();
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