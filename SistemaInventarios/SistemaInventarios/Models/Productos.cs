using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInventarios.Models
{
    public class Productos
    {
        [Key]
        public Int32 ProdctoId { get; set; }
        [Required]
        [StringLength (100)]
        public string NombreProducto { get; set; }
        [Required]
        [Range(0,10000, ErrorMessage = "Solo es permitido de {0} a {1}")]
        public Int32 CantidadProducto { get; set; }
        [Required]
        //[MinLength(0)]
        public Decimal PrecioProducto { get; set; }
        [Required]
        public Int32 MarcaId { get; set; }

        public virtual  Marca Marca { get; set; }
    }
}
