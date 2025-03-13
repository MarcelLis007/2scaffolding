using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StoreGui.Models;

[Table("Cliente")]
public partial class Cliente
{
    [Key]
    [Column("ClienteID")]
    public int ClienteId { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(20)]
    public string? Telefono { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    [InverseProperty("Cliente")]
    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
