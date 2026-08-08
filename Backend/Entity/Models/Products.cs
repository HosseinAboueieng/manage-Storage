using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entity.Models;

public class Products
{
    [Key]
    [Column("productId")]
    public Guid id { get; set; }

    [StringLength(30)]
    [Required]
    public  String? ProductsName { get; set; }
    [StringLength(30)]
    public String? companyName { get; set; }

    public ICollection<Storage>? Storages { get; set; }
    public Guid goupProductId { get; set; }
    [ForeignKey(nameof(goupProductId))]
    public GroupOfProduct? groupOfProduct { get; set; }
}
