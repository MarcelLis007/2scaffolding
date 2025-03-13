using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StoreGui.Models;

public partial class Categorium
{
    [Key]
    [Column("CategoriaID")]
    public int CategoriaId { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(200)]
    public string? Descripcion { get; set; }

    public int? EdadMinima { get; set; }

    [Column("RequiereID")]
    public bool RequiereId { get; set; }

    [InverseProperty("Categoria")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
