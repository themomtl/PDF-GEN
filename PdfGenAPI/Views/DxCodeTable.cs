using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PdfGenAPI.Views;

[Table("tbl_app_dx_codes")]
public class DxCodeTable
{
    [Key]
    [Column("DX_Code")]
    public string DxCodes { get; set; }

    [Column("DX_Descripton")]
    public string? DxDescription { get; set; }

    [Column("DX_Code_desc")]
    public string? DxCodesDescription { get; set; }
}
