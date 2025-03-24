using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StoreGui.Models;

[Table("Producto")]
public partial class Producto
{
    [Key]
    [Column("ProductoID")]
    public int ProductoId { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(500)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Precio { get; set; }

    public int StockDisponible { get; set; }

    [Column("CategoriaID")]
    public int CategoriaId { get; set; }

    [Column("ProveedorID")]
    public int ProveedorId { get; set; }

    [ForeignKey("CategoriaId")]
    [InverseProperty("Productos")]
    public virtual Categorium Categoria { get; set; } = null!;

    [InverseProperty("Producto")]
    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    [ForeignKey("ProveedorId")]
    [InverseProperty("Productos")]
    public virtual Proveedor Proveedor { get; set; } = null!;
}
