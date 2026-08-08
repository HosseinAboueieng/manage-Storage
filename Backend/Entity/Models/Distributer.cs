using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models;

public class Distributer
{
    [Column("distributerId")]
    [Required]
    [Key]
    public Guid id { get; set; }


    [RegularExpression(@"^09\d{9}$",ErrorMessage = "شماره موبایل باید به صورت 09xxxxxxxxx باشد.")]
    public string? PhoneNumber { get; set; }


    [Required  ]
    [StringLength(30)]
    public String? firstName { get; set; }
    
    [Required]
    [StringLength(30)]
    public String? lastName { get; set; }

}
