using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StoreGui.Models
{
    public partial class Ventum
    {
        [Key]
        [Column("VentaID")]
        public int VentaId { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now; // Corrección: Cambio de DateOnly a DateTime

        [Column("ClienteID")]
        [Required]
        public int ClienteId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El total de la venta debe ser mayor que 0.")]
        public decimal TotalVenta { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "El método de pago es obligatorio.")]
        public string MetodoPago { get; set; } = string.Empty; // Corrección: Evita valores nulos

        [ForeignKey("ClienteId")]
        [InverseProperty("Venta")]
        public virtual Cliente Cliente { get; set; } = null!;

        [InverseProperty("Venta")]
        public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();
    }
}
