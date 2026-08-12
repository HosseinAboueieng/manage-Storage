using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

public class Check
{
    [Required]
    [StringLength(6)]
    [Key]
    public String CheckSerie { get; set; }

    [Required]
    public bool payStatus { get; set; } = false;

    [Required]
    public DateOnly DateOfCheck { get; set; }

    [StringLength(30)]
    public String? BankName { get; set; }

    public Guid FactorId { get; set; }
    [ForeignKey(nameof(FactorId))]
    public BuyFactor? buyFactor { get; set; }

}
