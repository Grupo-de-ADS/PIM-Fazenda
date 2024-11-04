using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentosCrud.Models
{
    public class TransportModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tp_id { get; set; }

        [ForeignKey("sp_id")]
        public int sp_corporate_name { get; set; }

        [Required(ErrorMessage = "Digite o nome!")]
        public string tp_responsible_name { get; set; }

        [Required(ErrorMessage = "Digite o Cpf!")]
        public string tp_responsible_cpf { get; set; }

        [Required(ErrorMessage = "Digite o Telefone!")]
        public string tp_responsible_phone { get; set; }

        [Required(ErrorMessage = "Digite a Placa!")]
        public string tp_plate { get; set; }

        [Required(ErrorMessage = "Digite o peso da carga!")]
        public string tp_weight_supported { get; set; }

        [Required(ErrorMessage = "Digite o tamanho do veículo!")]
        public string tp_size { get; set; }

    }
}
