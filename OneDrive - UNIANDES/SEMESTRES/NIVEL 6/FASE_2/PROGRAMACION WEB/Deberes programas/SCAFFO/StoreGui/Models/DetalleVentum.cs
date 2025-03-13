using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StoreGui.Models;

public partial class DetalleVentum
{
    [Key]
    [Column("DetalleVentaID")]
    public int DetalleVentaId { get; set; }

    [Column("VentaID")]
    public int VentaId { get; set; }

    [Column("ProductoID")]
    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PrecioUnitario { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Subtotal { get; set; }

    [ForeignKey("ProductoId")]
    [InverseProperty("DetalleVenta")]
    public virtual Producto Producto { get; set; } = null!;

    [ForeignKey("VentaId")]
    [InverseProperty("DetalleVenta")]
    public virtual Ventum Venta { get; set; } = null!;
}
