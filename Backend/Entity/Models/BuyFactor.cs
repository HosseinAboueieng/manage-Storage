using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

[Index(nameof(ProductId), nameof(DistributerId), IsUnique = true)]
public class BuyFactor
{
    [Required]
    [Column("FactorId")]
    [Key]
    public Guid Id { get; set; }
    public DateOnly BuyDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalPrice { get; set; }

    public int Count { get; set; }

    // Foreign Key & Navigation for Product
    public Guid ProductId { get; set; }

    [ForeignKey(nameof(ProductId))]
    public Products? Product { get; set; }

    // Foreign Key & Navigation for Distributer
    public Guid DistributerId { get; set; }

    [ForeignKey(nameof(DistributerId))]
    public Distributer? Distributer { get; set; }
}