using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PdfGenAPI
{
    [Table("vw_pra_bims_2")]
    public class BimsTable : BaseTable
    {
        [Key]
        [Column("bims_id")]
        public string? Id { get; set; }

        [Column("cl_id")]
        public int? ClientId { get; set; }

        [Column("cl_name")]
        public string? ClientName { get; set; }

        [Column("prov_id")]
        public string? ProviderId { get; set; }

        [Column("prov_name")]
        public string? Provider { get; set; }

        [Column("facility_id")]
        public int? FacilityId { get; set; }

        [Column("facility_name")]
        public string? FacilityName { get; set; }

        [Column("bims_dte", TypeName = "datetime")]
        public DateTime? BimsDate { get; set; }

        [Column("q_words")]
        public string? QNumberOfWords { get; set; }

        [Column("q_year")]
        public string? QYearNow { get; set; }

        [Column("q_month")]
        public string? QMonthNow { get; set; }

        [Column("q_day")]
        public string? QDayNow { get; set; }

        [Column("rec_1")]
        public string? QRecallFirst { get; set; }

        [Column("rec_2")]
        public string? QRecallSecond { get; set; }

        [Column("rec_3")]
        public string? QRecallThird { get; set; }

        [Column("bims_score")]
        public string? SummaryScore { get; set; }

        [Column("int_complete")]
        public string? AbleToComplete { get; set; }

        [Column("enter_dte", TypeName = "datetime")]
        public DateTime? EnteredDate { get; set; }

        [Column("mod_dte", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }

        [Column("bims_sig")]
        public string? Signature { get; set; }

        [Column("bims_sig_dte", TypeName = "datetime")]
        public DateTime? SignatureDate { get; set; }

        [Column("bims_del")]
        public int? IsDeleted { get; set; }

        [Column("bims_del_dte", TypeName = "datetime")]
        public DateTime? DeleteDate { get; set; }

        [Column("provider_type")]
        public string? ProviderType { get; set; }

        [Column("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
    }
}
