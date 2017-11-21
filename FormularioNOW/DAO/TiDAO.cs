using FormularioNOW.Context;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioNOW.DAO
{
    public class TiDAO
    {
            #region Cadastrar TI
            public static void CadastrarTi(NOW now)
            {
                using (var ctx = new NowContext())
                {
                    ctx.Now.Find(now.ID_now).TI = now.TI;
                    ctx.Now.Find(now.ID_now).TI_status = true;
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
                        return ctx.Now.Where(a => a.TI_status == false && a.Produto_status == true).ToList();
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