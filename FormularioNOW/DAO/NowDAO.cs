using FormularioNOW.Context;
using FormularioNOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioNOW.DAO
{
    public static class NowDAO
    {
        #region Cadastrar NOW
        public static void Cadastrar(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Add(now);
                ctx.SaveChanges();
            }
        }
        #endregion
        
        #region Cadastrar QUALIDADE
        /*public static void CadastrarQualidade(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Find(now.ID_now).Qualidade = now.Qualidade;
                ctx.Now.Find(now.ID_now).Qualidade_status = true;
                ctx.SaveChanges();
            }
        }*/
        #endregion

        #region Cadastrar TI
       /* public static void CadastrarTI(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Find(now.ID_now).TI = now.TI;
                ctx.Now.Find(now.ID_now).TI_status = true;
                ctx.SaveChanges();
            }
        }*/
        #endregion

        #region Editar TUDO
        public static void editarTudo(NOW now)
        {
            using (var ctx = new NowContext())
            {
                ctx.Now.Find(now.ID_now).Nome = now.Nome;
                ctx.Now.Find(now.ID_now).Descricao = now.Descricao;
                ctx.Now.Find(now.ID_now).Compras = now.Compras;
                ctx.Now.Find(now.ID_now).Engenharia = now.Engenharia;
                ctx.Now.Find(now.ID_now).Qualidade = now.Qualidade;
                ctx.Now.Find(now.ID_now).TI = now.TI;

                ctx.Now.Find(now.ID_now).Compras_status = now.Compras_status;
                ctx.Now.Find(now.ID_now).Engenharia_status = now.Engenharia_status;
                ctx.Now.Find(now.ID_now).Qualidade_status = now.Qualidade_status;
                ctx.Now.Find(now.ID_now).TI_status = now.TI_status;

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
                    return ctx.Now.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            };
        }
        #endregion

        #region Pesquisar por Id
        public static NOW pesquisarID(int id)
        {
            using (var ctx = new NowContext())
            {
                return ctx.Now.Find(id);
            }
        }
        #endregion

        #region Pesquisar por nome e desc
        public static List<NOW> pesquisarNome(string pesquisa)
        {
            using (var ctx = new NowContext())
            {
                return ctx.Now.Where(a => a.Nome.Contains(pesquisa) || a.Descricao.Contains(pesquisa)).ToList();
            }
        }
        #endregion

    }
}