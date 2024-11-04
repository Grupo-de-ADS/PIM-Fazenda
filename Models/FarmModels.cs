using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentosCrud.Models
{
    public class FarmModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int farm_id { get; set; }

        [Required(ErrorMessage = "Digite o nome!")]
        public string farm_name { get; set; }

        [Required(ErrorMessage = "Digite o uf!")]
        public string farm_uf { get; set; }

        [Required(ErrorMessage = "Digite a cidade!")]
        public string farm_city { get; set; }

        [Required(ErrorMessage = "Digite o distrito!")]
        public string farm_distric { get; set; }

        [Required(ErrorMessage = "Digite o endereço!")]
        public string farm_address { get; set; }
    }
}
