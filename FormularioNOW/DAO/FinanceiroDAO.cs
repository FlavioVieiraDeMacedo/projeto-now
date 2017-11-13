using FormularioNOW.Context;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioNOW.DAO
{
    public class FinanceiroDAO
    {
        #region Cadastrar FINANCEIRO
        public static void CadastrarFinanceiro(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Find(now.ID_now).Financeiro = now.Financeiro;
                ctx.Now.Find(now.ID_now).Financeiro_status = true;
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
                    return ctx.Now.Where(a => a.Financeiro_status == false &&
                                              a.TI_status == true && 
                                              a.Engenharia_status == true && 
                                              a.ProdSoft_status == true &&
                                              a.Qualidade_status == true &&
                                              a.Compras_status == true &&
                                              a.ProdSoft_status == true).ToList();
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