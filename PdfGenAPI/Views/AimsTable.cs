using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PdfGenAPI.Views;

[Table("tbl_app_aims")]
public class AimsTable : BaseTable
{
    [Key]
    [Column("aims_id")]
    public string? AimsId { get; set; }

    [Column("med_page")]
    public string? MedPage { get; set; }

    [Column("aims_date")]
    public DateTime AimsDate { get; set; }

    [Column("roster_id")]
    public string? RosterId { get; set; }

    [Column("cl_id")]
    public int? SupcareId { get; set; }

    [Column("cl_name")]
    public string? PatientName { get; set; }

    [Column("prov_id")]
    public string? ProviderId { get; set; }

    [Column("prov_name")]
    public string? ProviderName { get; set; }

    [Column("facility_id")]
    public int FacilityId { get; set; }

    [Column("facility_name")]
    public string? FacilityName { get; set; }

    [Column("enter_dte")]
    public DateTime? EnterDate { get; set; }

    [Column("mod_dte")]
    public DateTime? ModifiedDate { get; set; }

    [Column("med_label")]
    public string? MedLable { get; set; }

    [Column("med_1")]
    public string? MedicationOne { get; set; }

    [Column("med_1_mg")]
    public string? MedicationOneDosage { get; set; }

    [Column("med_2")]
    public string? MedicationTwo { get; set; }

    [Column("med_2_mg")]
    public string? MedicationTwoDosage { get; set; }

    [Column("med_3")]
    public string? MedicationThree { get; set; }

    [Column("med_3_mg")]
    public string? MedicationThreeDosage { get; set; }

    [Column("exam_page")]
    public string? ExamPage { get; set; }

    [Column("fom_label")]
    public string? FacialLable { get; set; }

    [Column("fom_muscle")]
    public string? FacialMuscle { get; set; }

    [Column("fom_lips")]
    public string? FacialLips { get; set; }

    [Column("fom_jaw")]
    public string? FacialJaw { get; set; }

    [Column("fom_tongue")]
    public string? FacialTongue { get; set; }

    [Column("em_label")]
    public string? ExtremityLable { get; set; }

    [Column("em_upper")]
    public string? ExtremityUpper { get; set; }

    [Column("em_lower")]
    public string? ExtremityLower { get; set; }

    [Column("tm_label")]
    public string? TrunkLable { get; set; }

    [Column("tm_neck")]
    public string? TrunkNeck { get; set; }

    [Column("scoring_label")]
    public string? ScoringLable { get; set; }

    [Column("os_label")]
    public string? OverallLable { get; set; }

    [Column("os_severity")]
    public string? OverallSeverity { get; set; }

    [Column("os_incap")]
    public string? OverallIncapacity { get; set; }

    [Column("os_aware")]
    public string? OverallAwareness { get; set; }

    [Column("ds_label")]
    public string? DentalLable { get; set; }

    [Column("ds_probs")]
    public string? DentalProblems { get; set; }

    [Column("ds_dentures")]
    public string? DentalDentures { get; set; }

    [Column("aims_comments")]
    public string? AimsComments { get; set; }

    [Column("aims_next_dte")]
    public DateTime? AimsNextDate { get; set; }

    [Column("aims_sig")]
    public string? AimsSignature { get; set; }
}
