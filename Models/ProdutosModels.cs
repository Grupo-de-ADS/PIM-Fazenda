using System.ComponentModel.DataAnnotations;

namespace GerenciamentosCrud.Models
{
    public class ProdutosModels
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o código Ean!")]
        public double? Product_ean_code { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Produto!")]
        public string Product_name  { get; set; }

        [Required(ErrorMessage = "Digite a Quantidade do Produto!")]
        public double? Product_quantity { get; set; }

        [Required(ErrorMessage = "Digite a Data de Fabricação!")]
        public DateTime? Product_fabrication_date { get; set; }

        [Required(ErrorMessage = "Digite a Data de Validade!")]
        public DateTime? Product_expiry_date { get; set; }

    }
}
