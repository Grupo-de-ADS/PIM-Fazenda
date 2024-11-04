using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentosCrud.Models
{
    public class CustomerModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int customer_id { get; set; }

        [Required(ErrorMessage = "Digite o nome!")]
        public string customer_name { get; set; }

        [Required(ErrorMessage = "Digite o endereço!")]
        public string customer_address { get; set; }

        [Required(ErrorMessage = "Digite o numero de telefone!")]
        public string customer_phone_number { get; set; }

        public bool customer_is_juridic { get; set; }

        [Required(ErrorMessage = "Digite o CPF/CNPJ!")]
        public string customer_document { get; set; }
    }
}
