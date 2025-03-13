using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StoreGui.Models;

[Table("Proveedor")]
public partial class Proveedor
{
    [Key]
    [Column("ProveedorID")]
    public int ProveedorId { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(20)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(200)]
    public string? Direccion { get; set; }

    [InverseProperty("Proveedor")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
