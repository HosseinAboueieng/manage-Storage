using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Entity.Models;

public class Storage
{
    [Key]
    [Column("StorageId")]
    public Guid Id { get; set; }

    [Required]
    public decimal BuyPrice { get; set; }

    [Required]
    public decimal SellPrice { get; set; }

    [Required]
    public DateOnly ExpiredDate { get; set; }

    [Required]
    public int Count { get; set; }


    [ForeignKey(nameof(Product))]
    public Guid ProductId { get; set; }

    public Products? Product { get; set; }
}
