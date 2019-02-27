using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInventarios.Models
{
    public class Marca
    {
        [Key]
        public Int32 MarcaId { get; set; }
        [Required]
        [StringLength(100)]
        public String NombreMarca { get; set; }


        public virtual ICollection<Productos> Productos { get; set; }
    }
}
