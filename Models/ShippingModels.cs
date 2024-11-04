using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentosCrud.Models
{
    public class ShippingModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sp_id { get; set; }

        [Required(ErrorMessage = "Digite o nome da empresa!")]
        public string sp_corporate_name { get; set; }

        [Required(ErrorMessage = "Digite o Cnpj!")]
        public string sp_cnpj { get; set; }

        [Required(ErrorMessage = "Digite o nome!")]
        public string sp_responsible_name { get; set; }

        [Required(ErrorMessage = "Digite o Cpf!")]
        public string sp_responsible_cpf { get; set; }

        [Required(ErrorMessage = "Digite o numero para contato!")]
        public string sp_responsible_phone { get; set; }
    }
}
