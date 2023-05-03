using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatorio Informar o nome!")]
        public string? Name { get; set;}
        [Required(ErrorMessage ="Obrigatorio Informar a placa!")]
        public string? Placa { get; set;}
 
    }
}
