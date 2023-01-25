using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiControlStock.Validations;

namespace WebApiControlStock.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "char(1)")]
        [Required]
        [LineaProductoAttribute]
        public string LineaProducto{ get; set; }

        [Column(TypeName = "money")]
        [PrecioAttribute]
        public decimal Precio { get;set; }

        [ForeignKey(nameof(Categoria))]
        public int CategoriaId { get;set; }
        public Categoria Categoria { get; set;}
    }
}
