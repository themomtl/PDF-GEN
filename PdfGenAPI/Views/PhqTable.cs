using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PdfGenAPI
{
    [Table("vw_pra_phq9")]
    public class PhqTable : BaseTable
    {
        [Key]
        [Column("phq_id")]
        public string? Id { get; set; }

        [Column("cl_id")]
        public int? ClientId { get; set; }

        [Column("cl_name")]
        public string? ClientName { get; set; }

        [Column("prov_id")]
        public string? ProviderId { get; set; }

        [Column("prov_name")]
        public string? Provider { get; set; }

        [Column("phq_dte")]
        public DateTime? Session_date { get; set; }

        [Column("phq_enter_dte")]
        public DateTime? EnteredDate { get; set; }

        [Column("phq_mod_dte")]
        public DateTime? ModifiedDate { get; set; }

        [Column("fac_id")]
        public int? FacilityId { get; set; }

        [Column("fac_name")]
        public string? FacilityName { get; set; }

        [Column("interest")]
        public string? Interest { get; set; }

        [Column("down")]
        public string? Down { get; set; }

        [Column("sleep")]
        public string? Sleep { get; set; }

        [Column("energy")]
        public string? Energy { get; set; }

        [Column("appetite")]
        public string? Apettite { get; set; }

        [Column("feel_bad")]
        public string? Feel_bad { get; set; }

        [Column("concentrate")]
        public string? Concentrate { get; set; }

        [Column("slow_move")]
        public string? Slow_move { get; set; }

        [Column("thoughts")]
        public string? Thoughts { get; set; }

        [Column("difficult")]
        public string? Difficult { get; set; }

        [Column("sc_1")]
        public int Sc_1 { get; set; }

        [Column("sc_2")]
        public int sc_2 { get; set; }

        [Column("sc_3")]
        public int Sc_3 { get; set; }

        [Column("sc_4")]
        public int sc_4 { get; set; }

        [Column("sc_total")]
        public int Sc_total { get; set; }

        [Column("temp_1")]
        public string? InterviewConducted { get; set; }

        [Column("temp_2")]
        public string? OftenLonely { get; set; }

        [Column("temp_3")]
        public string? ServiceType { get; set; }

        [Column("prov_sig")]
        public string? Signature { get; set; }

        [Column("prov_sig_dte")]
        public DateTime? SignatureDate { get; set; }

        [Column("provider_type")]
        public string? ProviderType { get; set; }

        [Column("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
    }
}
