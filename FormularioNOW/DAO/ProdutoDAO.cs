using FormularioNOW.Context;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioNOW.DAO
{
    public class ProdutoDAO
    {
        #region Cadastrar PRODUTO
        public static void CadastrarProduto(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Find(now.ID_now).Produto = now.Produto;
                ctx.Now.Find(now.ID_now).Produto_status = true;
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
                    return ctx.Now.Where(a => a.Produto_status == false).ToList();
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