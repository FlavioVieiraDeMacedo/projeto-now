using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormularioNOW.Models
{
    public class NOW
    {
        [Key]
        public int ID_now { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool Engenharia_status { get; set; }
        public string Engenharia { get; set; }
        public string ComentariosParaEngenharia { get; set; }
        public bool NecessitaNovaMaquina { get; set; }
        public string DescricaoMaquina { get; set; }

        public bool Compras_status { get; set; }
        public string Compras { get; set; }
        public string ComentariosParaCompras { get; set; }

        public bool TI_status { get; set; }
        public string TI { get; set; }
        public string ComentariosParaTI { get; set; }

        public bool Qualidade_status { get; set; }
        public string Qualidade { get; set; }
        public string ComentariosParaQualidade { get; set; }

        public bool ProdSoft_status { get; set; }
        public string ProdSoft { get; set; }
        public string ComentariosParaProdSoft { get; set; }

        public bool Financeiro_status { get; set; }
        public string Financeiro { get; set; }
        public string ComentariosParaFinanceiro { get; set; }

        public bool Produto_status { get; set; }
        public string Produto { get; set; }
        public string ComentariosParaProduto { get; set; }
    }
}