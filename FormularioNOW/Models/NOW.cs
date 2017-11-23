using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormularioNOW.Models
{
    public class NOW
    {
        #region GERAL
        [Key]
        public int ID_now { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        #endregion

        #region ENGENHARIA
            #region GERAL
                public bool Engenharia_status { get; set; }
                public string Engenharia { get; set; }
                public string ComentariosParaEngenharia { get; set; }
                public bool NecessitaNovaMaquina { get; set; }
                public string DescricaoMaquina { get; set; }

                [Display(Name = "Produção de Cartão")]
                public bool ProducaoCartao { get; set; }
                [Display(Name = "Produção de Carta Berço")]
                public bool ProducaoBerco { get; set; }
                [Display(Name = "Inicialização de Módulos")]
                public bool InicializaModulo { get; set; }
                [Display(Name = "Personalização de cartão")]
                public bool PersonalizaCartao { get; set; }
                [Display(Name = "Personalização de carta berço")]
                public bool PersonalizaBerco { get; set; }
                [Display(Name = "Folheteria")]
                public bool Folheteria { get; set; }
                [Display(Name = "Embalagem e Expedição")]
                public bool EmbalagemEExpedicao { get; set; }

                [Display(Name = "Qual Chip será utilizado")]
                public string Chip { get; set; }
                [Display(Name = "Qual bandeira será utilizado nesse produto")]
                public string Bandeira { get; set; }
                [Display(Name = "Qual tipo de aplicação será utilizado")]
                public string TipoAplicacao { get; set; }
                [Display(Name = "Que tipo de cartão será emitido")]
                public string TipoCartao { get; set; }

        #endregion

            #region IMPRESSAO
                [Display(Name = "Tipo de Impressão")]
                public string TipoImpressao { get; set; }
                [Display(Name = "Cores Frente x Cores Verso")]
                public string coresFrenteVerso { get; set; }
                [Display(Name = "Invisível")]
                public string Invisivel { get; set; }
            #endregion

            #region CARTAO
                [Display(Name = "Funcionalidade")]
                public string Funcionalidade { get; set; }
                [Display(Name = "Tamanho do Cartão")]
                public string TamanhoCartao { get; set; }
                [Display(Name = "Material do Cartão")]
                public string MaterialCartao { get; set; }
                [Display(Name = "Espessura do Cartão")]
                public string EspessuraCartao { get; set; }
                [Display(Name = "Painel de Assinatura")]
                public string PainelAssinatura { get; set; }
                [Display(Name = "Holograma")]
                public string Holograma { get; set; }
                [Display(Name = "Kinegrama")]
                public string Kinegrama { get; set; }
                [Display(Name = "MLI")]
                public string MLI { get; set; }
                [Display(Name = "Relevo Táctil ")]
                public string RelevoTactil { get; set; }
                [Display(Name = "Tinta de Segurança")]
                public string TintaSeguranca { get; set; }
                [Display(Name = "OVI")]
                public string OVI { get; set; }
                [Display(Name = "UV")]
                public string UV { get; set; }
                [Display(Name = "IR")]
                public string IR { get; set; }
                [Display(Name = "Hot Stamping")]
                public string HotStamping { get; set; }
                [Display(Name = "Plug-in Punching")]
                public string PlugInPuching { get; set; }
                [Display(Name = "Milling")]
                public string Milling { get; set; }
                [Display(Name = "Embedding")]
                public string Embedding { get; set; }
                [Display(Name = "Aplicação de Glue Tape")]
                public string GlupeTape { get; set; }
                [Display(Name = "Anti Scanner")]
                public string AntiScanner { get; set; }
            #endregion

            #region PERSONALIZACAO
                [Display(Name = "Perso machine")]
                public string PersoMachine { get; set; }
                [Display(Name = "Embossing")]
                public string Embossing { get; set; }
                [Display(Name = "Termo")]
                public string Termo { get; set; }
                [Display(Name = "Cor da Fita Termo")]
                public string CorFitaTermo { get; set; }
                [Display(Name = "Tarja Magnética")]
                public string TarjaMagnetica { get; set; }
                [Display(Name = "Card Gard (Apenas Termo)")]
                public string GuardCard { get; set; }
                [Display(Name = "Foto")]
                public string Foto { get; set; }
                [Display(Name = "Chip perso")]
                public string ChipPerso { get; set; }
                [Display(Name = "Mifare perso")]
                public string MifarePerso { get; set; }
                [Display(Name = "Laser engraving")]
                public string LaserEngraving { get; set; }
                [Display(Name = "Laser engraving Policarbonato")]
                public string LaserEngravingPolicarbonato { get; set; }
                [Display(Name = "Captura de imagem e editoração")]
                public string CapturaEditora { get; set; }
                [Display(Name = "Etiqueta Raspadinha")]
                public string EtiquetaRaspadinha { get; set; }
            #endregion

            #region VOLUMES
                [Display(Name = "Volume Total estimado")]
                public string VolumeTotal { get; set; }
                [Display(Name = "SLA(unidades / dia)")]
                public string SLA { get; set; }
            #endregion

            #region FOLHETERIA
                [Display(Name = "Manuseio")]
                public string Manuseio { get; set; }
                [Display(Name = "Folheteria Própria")]
                public string FolheteriaPropria { get; set; }
                [Display(Name = "Kit contém")]
                public string KitContem { get; set; }
                [Display(Name = "Gramatura Berco")]
                public string GramaturaBerco { get; set; }
                [Display(Name = "Gramatura Envelope")]
                public string GramaturaEnvelope { get; set; }
                [Display(Name = "Cor Berco")]
                public string CorBerco { get; set; }
                [Display(Name = "Cor Envelope")]
                public string CorEnvelope { get; set; }
                [Display(Name = "Tamanho Berco")]
                public string TamanhoBerco { get; set; }
                [Display(Name = "Tamanho Envelope")]
                public string TamanhoEnvelope { get; set; }
                [Display(Name = "Embalagem")]
                public string Embalagem { get; set; }
                [Display(Name = "Destruição")]
                public string Destruicao { get; set; }
                [Display(Name = "Etiquetas (se Sim, detalhar)")]
                public string Etiqueta { get; set; }
            #endregion
        #endregion

        #region COMPRAS
            public bool Compras_status { get; set; }
            public string Compras { get; set; }
            public string ComentariosParaCompras { get; set; }

            [Display(Name = "Incluir Custo com Amostra?")]
            public string CustoComAmostra { get; set; }
            [Display(Name = "Frete pago pela GD Burti?")]
            public string FreteGD { get; set; }
            [Display(Name = "UF Destino da Mercadoria")]
            public string UFDestino { get; set; }
            [Display(Name = "CEP Destino")]
            public string CepDestino { get; set; }
            [Display(Name = "Frete Segurança?")]
            public string FreteSeguranca { get; set; }

        #endregion

        #region TI
            public bool TI_status { get; set; }
            public string TI { get; set; }
            public string ComentariosParaTI { get; set; }
            [Display(Name = "O Arquivo é transmitido por uma empresa terceira?")]
            public string TransmitidoTerceiro { get; set; }
        #endregion

        #region QUALIDADE
            public bool Qualidade_status { get; set; }
            public string Qualidade { get; set; }
            public string ComentariosParaQualidade { get; set; }
        #endregion

        #region PRODSOFT
            public bool ProdSoft_status { get; set; }
            public string ProdSoft { get; set; }
            public string ComentariosParaProdSoft { get; set; }

            [Display(Name = "Será impresso mensagens variáveis no berço")]
            public string MsgVisivelBerco { get; set; }
            [Display(Name = "Qual o formato do berço ")]
            public string FormatoBerco { get; set; }
            [Display(Name = "Qual o formato da Dobra ")]
            public string FormatoDobra { get; set; }
            [Display(Name = "Existe algum processo de triagem/separação")]
            public string Triagem { get; set; }
            [Display(Name = "Existem retenções ")]
            public string Retencao { get; set; }
            [Display(Name = "Chip Data Generation")]
            public bool ChipDataGeneration { get; set; }
            [Display(Name = "Chip Data Preparation")]
            public bool ChipDataPreparation { get; set; }
            [Display(Name = "Key and Certificate Management")]
            public bool KeyAndCertificateManagement { get; set; }
            [Display(Name = "Tratamento de Devolução")]
            public string TratamentoDevolucao { get; set; }
            [Display(Name = "Expedição")]
            public string Expedicao { get; set; }
        #endregion

        #region FINANCEIRO
            public bool Financeiro_status { get; set; }
            public string Financeiro { get; set; }
            public string ComentariosParaFinanceiro { get; set; }
        #endregion

        #region PRODUTO
            public bool Produto_status { get; set; }
            public string Produto { get; set; }
            public string ComentariosParaProduto { get; set; }
            [Display(Name = "Módulo de Contato (desc.)")]
            public string ModuloContato { get; set; }
            [Display(Name = "Módulo sem Contato (desc.)")]
            public string ModuloSemContato { get; set; }
        #endregion
    }
}