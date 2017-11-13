using FormularioNOW.Context;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioNOW.DAO
{
    public class QualidadeDAO
    {
        #region Cadastrar QUALIDADE
        public static void CadastrarQualidade(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Find(now.ID_now).Qualidade = now.Qualidade;
                ctx.Now.Find(now.ID_now).Qualidade_status = true;
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
                    return ctx.Now.Where(a => a.Qualidade_status == false).ToList();
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