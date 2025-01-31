using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PdfGenAPI.Views;

[Table("tbl_app_timesheets_psych_raw_3")]
public class PsychiatryEvalTable
{
    [Key]
    [Column("UniqueId")]
    public string? NoteId { get; set; }

    [Column("facility_name")]
    public string? FacilityName { get; set; }

    [Column("facility_id")]
    public int SupcareFacId { get; set; }

    [Column("Provider")]
    public string? Provider { get; set; }

    [Column("Provider_ID")]
    public string? ProviderId { get; set; }

    [Column("Client_Name")]
    public string? ClientName { get; set; }

    [Column("cl_id")]
    public int SupcarePatientId { get; set; }

    [Column("DOB")]
    public DateTime? DateOfBirth { get; set; }

    [Column("ses_date")]
    public DateTime? SessionDate { get; set; }

    [Column("ses_abs")]
    public string? IsPresent { get; set; }

    [Column("absent_note")]
    public string? AbsentNote { get; set; }

    [Column("Start_Time")]
    public DateTime? StartTime { get; set; }

    [Column("End_Time")]
    public DateTime? EndTime { get; set; }

    [Column("CPT_Code")]
    public string? CptCode { get; set; }

    [Column("cpt_addon")]
    public string? CptAddon { get; set; }

    [Column("DX_Code")]
    public string? DxCode { get; set; }

    [Column("DX_Code_2")]
    public string? DxCode2 { get; set; }

    [Column("DX_Code_3")]
    public string? DxCode3 { get; set; }

    [Column("DX_Code_4")]
    public string? DxCode4 { get; set; }

    [Column("Allergies")]
    public string? Allergies { get; set; }

    [Column("complaint")]
    public string? Complaints { get; set; }

    [Column("source")]
    public string? Source { get; set; }

    [Column("cur_illness")]
    public string? CurrentIllness { get; set; }

    [Column("Hx_Psych")]
    public bool? HxPsych { get; set; }

    [Column("np_psych")]
    public string? NpPsych { get; set; }

    [Column("np_Endocrine")]
    public string? NpEndocrine { get; set; }

    [Column("np_Respiratory")]
    public string? NpRespiratory { get; set; }

    [Column("np_gu")]
    public string? NpGu { get; set; }

    [Column("np_neuro")]
    public string? NpNeuro { get; set; }

    [Column("np_const")]
    public string? NpConstitutional { get; set; }

    [Column("np_ambu")]
    public string? NpAmbulation { get; set; }

    [Column("np_adl")]
    public string? NpAdl { get; set; }

    [Column("np_muscul")]
    public string? NpMusculoskeletal { get; set; }

    [Column("np_cardio")]
    public string? NpCardio { get; set; }

    [Column("np_skin")]
    public string? NpSkin { get; set; }

    [Column("np_gi")]
    public string? NpGi { get; set; }

    [Column("np_Hema")]
    public string? NpHematological { get; set; }

    [Column("np_other")]
    public string? NpOther { get; set; }

    [Column("Np_other_txt")]
    public string? NpOtherText { get; set; }

    [Column("physicall_exam")]
    public string? PhysicallExam { get; set; }

    [Column("labs_1_ord")]
    public string? LabsOrderedOne { get; set; }

    [Column("labs_2_ord")]
    public string? LabsOrderedTwo { get; set; }

    [Column("labs_3_ord")]
    public string? LabsOrderedThree { get; set; }

    [Column("labs_4_ord")]
    public string? LabsOrderedFour { get; set; }

    [Column("labs_1_rev")]
    public string? LabsReviewedOne { get; set; }

    [Column("labs_1_rev_dte")]
    public DateTime? LabsReviewDateOne { get; set; }

    [Column("labs_1_rev_find")]
    public string? LabsReviewFindingsOne { get; set; }

    [Column("labs_1_rev_ord")]
    public string? LabsReviewOrderedOne { get; set; }

    [Column("labs_2_rev")]
    public string? LabsReviewedTwo { get; set; }

    [Column("labs_2_rev_dte")]
    public DateTime? LabsReviewDateTwo { get; set; }

    [Column("labs_2_rev_find")]
    public string? LabsReviewFindingsTwo { get; set; }

    [Column("labs_2_rev_ord")]
    public string? LabsReviewOrderedTwo { get; set; }

    [Column("labs_3_rev")]
    public string? LabsReviewedThree { get; set; }

    [Column("labs_3_rev_dte")]
    public DateTime? LabsReviewDateThree { get; set; }

    [Column("labs_3_rev_find")]
    public string? LabsReviewFindingsThree { get; set; }

    [Column("labs_3_rev_ord")]
    public string? LabsReviewOrderedThree { get; set; }

    [Column("labs_4_rev")]
    public string? LabsReviewedFour { get; set; }

    [Column("labs_4_rev_dte")]
    public DateTime? LabsReviewDateFour { get; set; }

    [Column("labs_4_rev_find")]
    public string? LabsReviewFindingsFour { get; set; }

    [Column("labs_4_rev_ord")]
    public string? LabsReviewOrderedFour { get; set; }

    [Column("phone_review")]
    public string? PhoneReview { get; set; }

    [Column("phone_with")]
    public string? PhoneWith { get; set; }

    [Column("phone_conv")]
    public string? PhoneConversation { get; set; }

    [Column("doc_review")]
    public string? DocReview { get; set; }

    [Column("doc_Findings")]
    public string? DocFindings { get; set; }

    [Column("med_1")]
    public string? MedicationOne { get; set; }

    [Column("med_1_dose")]
    public string? MedicationOneDosage { get; set; }

    [Column("med_1_dose_change")]
    public string? MedicationOneDosageChange { get; set; }

    [Column("med_2")]
    public string? MedicationTwo { get; set; }

    [Column("med_2_dose")]
    public string? MedicationTwoDosage { get; set; }

    [Column("med_2_dose_change")]
    public string? MedicationTwoDosageChange { get; set; }

    [Column("med_3")]
    public string? MedicationThree { get; set; }

    [Column("med_3_dose")]
    public string? MedicationThreeDosage { get; set; }

    [Column("med_3_dose_change")]
    public string? MedicationThreeDosageChange { get; set; }

    [Column("med_4")]
    public string? MedicationFour { get; set; }

    [Column("med_4_dose")]
    public string? MedicationFourDosage { get; set; }

    [Column("med_4_dose_change")]
    public string? MedicationFourDosageChange { get; set; }

    [Column("cond_prev")]
    public string? CondPrev { get; set; }

    [Column("cond_1")]
    public string? CondOne { get; set; }

    [Column("cond_1_stable")]
    public string? CondOneStable { get; set; }

    [Column("cond_1_course")]
    public string? CondOneCourse { get; set; }

    [Column("cond_1_plan")]
    public string? CondOnePlan { get; set; }

    [Column("cond_2")]
    public string? CondTwo { get; set; }

    [Column("cond_2_stable")]
    public string? CondTwoStable { get; set; }

    [Column("cond_2_course")]
    public string? CondTwoCourse { get; set; }

    [Column("cond_2_plan")]
    public string? CondTwoPlan { get; set; }

    [Column("cond_3")]
    public string? CondThree { get; set; }

    [Column("cond_3_stable")]
    public string? CondThreeStable { get; set; }

    [Column("cond_3_course")]
    public string? CondThreeCourse { get; set; }

    [Column("cond_3_plan")]
    public string? CondThreePlan { get; set; }

    [Column("cond_4")]
    public string? CondFour { get; set; }

    [Column("cond_4_stable")]
    public string? CondFourStable { get; set; }

    [Column("cond_4_course")]
    public string? CondFourCourse { get; set; }

    [Column("cond_4_plan")]
    public string? CondFourPlan { get; set; }

    [Column("gdr")]
    public string? GDR { get; set; }

    [Column("gdr_txt")]
    public string? GdrText { get; set; }

    [Column("np_aims")]
    public string? NpAims { get; set; }

    [Column("aims_date")]
    public DateTime? AimsDate { get; set; }

    [Column("danger")]
    public string? Danger { get; set; }

    [Column("cont_svce")]
    public string? ContSvce { get; set; }

    [Column("teleHealth")]
    public string? TeleHealth { get; set; }

    [Column("next_sched")]
    public string? NextScheduled { get; set; }

    [Column("Enter_date")]
    public DateTime? EnterDate { get; set; }

    [Column("Enter_time")]
    public string? EnterTime { get; set; }

    [Column("Mod_date")]
    public DateTime? ModDate { get; set; }

    [Column("Mod_time")]
    public string? ModTime { get; set; }

    [Column("prov_sig")]
    public string? Signature { get; set; }

    [Column("prov_sig_dte")]
    public DateTime? SignatureDate { get; set; }

    [Column("covered")]
    public string? Covered { get; set; }

    [Column("ts_delete")]
    public bool? TsDeleted { get; set; }

    [Column("Temp_100")]
    public string? Temp100 { get; set; }

    [Column("Temp_101")]
    public string? Temp101 { get; set; }

    [Column("Temp_102")]
    public string? Temp102 { get; set; }

    [Column("Temp_103")]
    public string? Temp103 { get; set; }

    [Column("Temp_104")]
    public string? Temp104 { get; set; }

    [Column("Temp_105")]
    public string? Temp105 { get; set; }

    [Column("Temp_106")]
    public string? Temp106 { get; set; }

    [Column("Temp_107")]
    public string? Temp107 { get; set; }

    [Column("Temp_108")]
    public string? Temp108 { get; set; }

    [Column("Temp_109")]
    public string? Temp109 { get; set; }

    [Column("Temp_110")]
    public string? Temp110 { get; set; }

    [Column("Temp_111")]
    public string? Temp111 { get; set; }

    [Column("Temp_112")]
    public string? Temp112 { get; set; }

    [Column("Temp_113")]
    public string? Temp113 { get; set; }

    [Column("Temp_114")]
    public string? Temp114 { get; set; }

    [Column("Temp_115")]
    public string? Temp115 { get; set; }

    [Column("Temp_116")]
    public string? Temp116 { get; set; }

    [Column("Temp_117")]
    public string? Temp117 { get; set; }

    [Column("Temp_118")]
    public string? Temp118 { get; set; }

    [Column("Temp_119")]
    public string? Temp119 { get; set; }

    [Column("Temp_120")]
    public string? Temp120 { get; set; }

    [Column("client")]
    public string? Client { get; set; }

    [Column("Orient_impair")]
    public string? OrientImpair { get; set; }

    [Column("doc_rev_name")]
    public string? DocRevName { get; set; }

    [Column("dx1_status")]
    public string? Dx1Status { get; set; }

    [Column("dx1_severity")]
    public string? Dx1Severity { get; set; }

    [Column("dx1_systemic")]
    public bool? Dx1Systemic { get; set; }

    [Column("dx1_risk")]
    public string? Dx1Risk { get; set; }

    [Column("dx2_status")]
    public string? Dx2Status { get; set; }

    [Column("dx2_severity")]
    public string? Dx2Severity { get; set; }

    [Column("dx2_systemic")]
    public bool? Dx2Systemic { get; set; }

    [Column("dx2_risk")]
    public string? Dx2Risk { get; set; }

    [Column("dx3_status")]
    public string? Dx3Status { get; set; }

    [Column("dx3_severity")]
    public string? Dx3Severity { get; set; }

    [Column("dx3_systemic")]
    public bool? Dx3Systemic { get; set; }

    [Column("dx3_risk")]
    public string? Dx3Risk { get; set; }

    [Column("dx4_status")]
    public string? Dx4Status { get; set; }

    [Column("dx4_severity")]
    public string? Dx4Severity { get; set; }

    [Column("dx4_systemic")]
    public bool? Dx4Systemic { get; set; }

    [Column("dx4_risk")]
    public string? Dx4Risk { get; set; }

    [Column("phone_review_doc")]
    public bool? PhoneReviewDoc { get; set; }

    [Column("phone_with_doc")]
    public string? PhoneWithDoc { get; set; }

    [Column("phone_conv_doc")]
    public string? PhoneConvDoc { get; set; }

    [Column("rationale_1")]
    public string? Rationale1 { get; set; }

    [Column("rationale_2")]
    public string? Rationale2 { get; set; }

    [Column("rationale_3")]
    public string? Rationale3 { get; set; }

    [Column("rationale_4")]
    public string? Rationale4 { get; set; }

    [Column("doc_review_doc")]
    public bool? DocReviewDoc { get; set; }

    [Column("doc_rev_name_doc")]
    public string? DocRevNameDoc { get; set; }

    [Column("doc_rev_findings_doc")]
    public string? DocRevFindingsDoc { get; set; }

    [Column("facility_id_curr")]
    public int? SupcareCurrentFacId { get; set; }
}
