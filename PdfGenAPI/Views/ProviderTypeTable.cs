using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PdfGenAPI.Views;

[Table("tbl_provider_type")]
public class ProviderTypeTable
{
    [Key]
    [Column("provider_type_id")]
    public int ProviderTypeId { get; set; }

    [Column("provider_type")]
    public string? ProviderType { get; set; }
}
