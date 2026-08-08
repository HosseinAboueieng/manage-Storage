using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

public class GroupOfProduct
{
    [Key]
    [Column("goupProductId")]
    [Required]
    public Guid id { get; set;}
    [Required]
    [StringLength(50)]
    public String? groupName { get; set; }
    public ICollection<Products>? products { get; set; }
}
