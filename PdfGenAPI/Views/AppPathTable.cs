using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PdfGenAPI.Views;

[Table("tbl_app_path")]
public class AppPathTable
{
    [Key]
    [Column("app_path_id")]
    public int AppPathId { get; set; }

    [Column("app_co")]
    public string? AppCo { get; set; }
}
