using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerApp.Data
{
    public class ProdutoFornecedorModel
    {
        public long Id { get; set; }
        public long IdPessoa { get; set; }
        public long IdProduto { get; set; }
        [Column(TypeName = "numeric(18, 7)")]
        public decimal VlrCusto { get; set; }
        [Column(TypeName = "numeric(18, 7)")]
        public decimal FatorConversao { get; set; }
        [StringLength(60)]
        public string CdProdForn { get; set; } // código do produto no fornecedor
        [StringLength(100)]
        public string DescProdForn { get; set; } // descrição do produto no fornecedor
        [StringLength(6)]
        public string CdUnidadeForn { get; set; } // unidade do produto vindo na nota do fornecedor
        [NotMapped]
        public string CdUnidadeFornAnt { get; set; } // unidade do produto do fornecedor já gravado no GAF
        //public PessoaModel Pessoa { get; set; }
        public ProdutoModel Produto { get; set; }
    }
}
