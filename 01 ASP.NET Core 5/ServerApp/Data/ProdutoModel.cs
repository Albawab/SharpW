using System;
using System.Collections.Generic;

namespace ServerApp.Data
{
    public class ProdutoModel
    {
        public long Id { get; set; }

        public string Codigo { get; set; }

        public int Tipo { get; set; }

        public long IdSubgrupo { get; set; }

        public long IdUnidade { get; set; }

        public long IdAliquota { get; set; }

        public long IdClassificacaoFiscal { get; set; }

        public string Nome { get; set; }

        public DateTime? DataCadastro { get; set; }

        public string CodigoDeBarras { get; set; }

        public decimal PercCustoVar { get; set; }

        public string Observacoes { get; set; }

        public decimal PercComissao { get; set; }


        public string LocalEstoque { get; set; }

        public decimal PercISQN { get; set; }

        public decimal FracaoHora { get; set; }

        public string AcaoServico { get; set; }

        public string CodigoANP { get; set; }

        public decimal PercMargemLucro { get; set; }

        public string CaminhoImagem { get; set; }

        public long? IdGenero { get; set; }

        public decimal PesoBruto { get; set; }

        public decimal PesoLiq { get; set; }

        public long? IdEmbalagem { get; set; }

        public decimal CustoDigitado { get; set; }

        public decimal PercICMSST { get; set; }

        public string ItemListaServico { get; set; }

        public string CdTributacaoMunicipio { get; set; }

        public decimal CustoProd { get; set; }

        public decimal VlrVenda { get; set; }

        public decimal Estoque { get; set; }

        public bool CompoeLMP { get; set; }

        public bool Ativo { get; set; } = true;

        public decimal EstoqueMinimo { get; set; }

        public bool CompoeNF { get; set; }

        public decimal CustoMedio { get; set; }

        public decimal VlrBaseICMSST { get; set; }

        public decimal VlrICMSST { get; set; }

        public bool AssociaVeiculo { get; set; }

        public long? IdGAF { get; set; }

        public decimal VlrPromocional { get; set; }
        public string CEST { get; set; }
        public bool TributaServicoNoMunicipio { get; set; }
        public decimal FatorQTrib { get; set; }

    //    public ClassificacaoFiscalModel ClassificacaoFiscal { get; set; }
    //    public EmbalagemModel Embalagem { get; set; }
    //    public GeneroProdutoModel Genero { get; set; }
    //    public SubgrupoProdutoModel Subgrupo { get; set; }
    //    public UnidadeProdutoModel Unidade { get; set; }
    //    public AliquotaModel Aliquota { get; set; }
    //    public string DescricaoTipoItem =>
    //        Tipo switch
    //        {
    //            (int)TipoProduto.Mercadoria           => "00 - Mercadoria",
    //            (int)TipoProduto.MateriaPrima         => "01 - Matéria-Prima",
    //            (int)TipoProduto.Servico              => "02 - Serviço",
    //            (int)TipoProduto.Produto              => "03 - Produto",
    //            (int)TipoProduto.Embalagem            => "04 - Embalagem",
    //            (int)TipoProduto.ProdutoEmProcesso    => "05 - Produto em Processo",
    //            (int)TipoProduto.Subproduto           => "06 - Subproduto",
    //            (int)TipoProduto.ProdutoIntermediario => "07 - Produto Intermediário",
    //            (int)TipoProduto.MaterialDeUsoConsumo => "08 - Material de Uso e Consumo",
    //            (int)TipoProduto.AtivoImobilizado     => "09 - Ativo Imobilizado",
    //            (int)TipoProduto.OutrosInsumos        => "10 - Outros insumos",
    //            (int)TipoProduto.Outras               => "11 - Outras",
    //            _                                => string.Empty
    //        };
    //public string DescricaoAtivo => Ativo ? "Ativo" : "Inativo";

    //    public ICollection<ProdutoPessoaModel> Pessoas { get; set; }


    }
}
