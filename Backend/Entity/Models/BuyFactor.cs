using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity.Models;

[PrimaryKey(nameof(ProductId), nameof(DistributerId))]
public class BuyFactor
{
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