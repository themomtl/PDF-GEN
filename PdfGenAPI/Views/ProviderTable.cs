using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PdfGenAPI.Views;

[Table("ProviderTable")]
public class ProviderTable
{
    [Key]
    [Column("ProviderID")]
    public string? ProviderId { get; set; }

    [Column("provider_type")]
    public int? ProviderType { get; set; }
}
