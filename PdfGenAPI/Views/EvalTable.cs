using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PdfGenAPI;

[Table("vw_pra_timesheets")]
public class EvalTable : BaseTable
{
    [Key]
    [Column("UniqueID")]
    public string? UId { get; set; }

    [Column("Provider_ID")]
    public string? ProviderId { get; set; }

    [Column("Provider")]
    public string? Provider { get; set; }

    [Column("Client_Name")]
    public string? ClientName { get; set; }

    [Column("cl_id")]
    public int? ClientId { get; set; }

    [Column("Client")]
    public string? Client { get; set; }

    [Column("Enter_date")]
    public DateTime? EnteredDate { get; set; }

    [Column("Enter_Time")]
    public DateTime? EnterTime { get; set; }

    [Column("Mod_Time")]
    public DateTime? ModTime { get; set; }

    [Column("ses_date")]
    public DateTime? SesDate { get; set; }

    [Column("ses_abs")]
    public string? SesAbs { get; set; }

    [Column("Start Time")]
    public DateTime? StartTime { get; set; }

    [Column("End Time")]
    public DateTime? EndTime { get; set; }

    [Column("CPT_Code")]
    public string? CPTCode { get; set; }

    [Column("CPT_Addon")]
    public string? CptAddon { get; set; }

    [Column("Initial")]
    public string? Initial { get; set; }

    [Column("Initial_Reason")]
    public string? InitialReason { get; set; }

    [Column("int_reason_note")]
    public string? InitialReasonNote { get; set; }

    [Column("cl_dob")]
    public DateTime? DOB { get; set; }

    [Column("facility")]
    public string? FacilityName { get; set; }

    [Column("facility_id")]
    public int? FacilityId { get; set; }

    [Column("mod_date")]
    public DateTime? ModifiedDate { get; set; }

    [Column("DX_1")]
    public string? DXCode { get; set; }

    [Column("DX_2")]
    public string? DXCode2 { get; set; }

    [Column("DX_3")]
    public string? DXCode3 { get; set; }

    [Column("DX_4")]
    public string? DXCode4 { get; set; }

    [Column("Service_Tab")]
    public string? ServiceTap { get; set; }

    [Column("SYMPTOMS - Physical")]
    public string? SymptomsPhysical { get; set; }

    [Column("SYMPTOMS - Psych")]
    public string? SymptomsPsych { get; set; }

    [Column("Functional")]
    public string? Functional { get; set; }

    [Column("STRESSORS_CHANGES")]
    public string? StressorsChanges { get; set; }

    [Column("Therapeutic")]
    public string? Therapeutic { get; set; }

    [Column("Psychotherapeutic")]
    public string? Psychotherapeutic { get; set; }

    [Column("Eval_Tab")]
    public string? EvalTab { get; set; }

    [Column("Appearance")]
    public string? Appearance { get; set; }

    [Column("Behavior")]
    public string? Behavior { get; set; }

    [Column("Affect")]
    public string? Affect { get; set; }

    [Column("Speech")]
    public string? Speech { get; set; }

    [Column("Thought_proc")]
    public string? ThoughtProc { get; set; }

    [Column("Thought_con")]
    public string? ThoughtCon { get; set; }

    [Column("Halucinations")]
    public string? Halucinations { get; set; }

    [Column("Delusions")]
    public string? Delusions { get; set; }

    [Column("Selef_Perception")]
    public string? SelefPerception { get; set; }

    [Column("Orientation")]
    public string? Orientation { get; set; }

    [Column("Memory")]
    public string? Memory { get; set; }

    [Column("Cognitive")]
    public string? Cognitive { get; set; }

    [Column("Judgment")]
    public string? Judgment { get; set; }

    [Column("Risk_factor")]
    public string? RiskFactor { get; set; }

    [Column("Results_Tab")]
    public string? ResultTab { get; set; }

    [Column("RESULTS")]
    public string? Results { get; set; }

    [Column("Results - Improved")]
    public string? ResultsImproved { get; set; }

    [Column("Results - Identified")]
    public string? ResultsIdentified { get; set; }

    [Column("Results - Reduced")]
    public string? ResultsReduced { get; set; }

    [Column("DISPOSITION")]
    public string? Disposition { get; set; }

    [Column("rat_cognitive")]
    public string? RatCognitive { get; set; }

    [Column("rat_treatment")]
    public string? RatTreatment { get; set; }

    [Column("rat_social")]
    public string? RatSocial { get; set; }

    [Column("rat_behave")]
    public string? RatBehave { get; set; }

    [Column("rat_psych")]
    public string? RatPsych { get; set; }

    [Column("rat_emotion")]
    public string? RatEmotion { get; set; }

    [Column("rat_interfer")]
    public string? RatInterfer { get; set; }

    [Column("rat_deter")]
    public string? RatDeter { get; set; }

    [Column("Prevention")]
    public string? Prevention { get; set; }

    [Column("Treatment")]
    public string? Treatment { get; set; }

    [Column("Thea_goals")]
    public string? TheaGoals { get; set; }

    [Column("Modalities")]
    public string? Modalities { get; set; }

    [Column("Recommendations")]
    public string? Recommendations { get; set; }

    [Column("Reco_notes")]
    public string? RecoNotes { get; set; }

    [Column("Frequency")]
    public string? Frequency { get; set; }

    [Column("ses_fam")]
    public string? SesFam { get; set; }

    [Column("ses_group")]
    public string? SesGroup { get; set; }

    [Column("Notes")]
    public string? Notes { get; set; }

    [Column("prov_sig")]
    public string? Signature { get; set; }

    [Column("sig_date")]
    public DateTime? SignatureDate { get; set; }

    [Column("covered")]
    public string? Covered { get; set; }

    [Column("ts_delete")]
    public bool? IsDeleted { get; set; }

    [Column("temp_2")]
    public string? Bims { get; set; }

    [Column("temp_3")]
    public string? QNumberOfWords { get; set; }

    [Column("temp_4")]
    public string? QYearNow { get; set; }

    [Column("temp_5")]
    public string? QMonthNow { get; set; }

    [Column("temp_6")]
    public string? QDayNow { get; set; }

    [Column("temp_7")]
    public string? QRecallfirst { get; set; }

    [Column("temp_8")]
    public string? QRecallSecond { get; set; }

    [Column("temp_9")]
    public string? QRecallThird { get; set; }

    [Column("temp_10")]
    public string? SummaryScore { get; set; }

    [Column("temp_11")]
    public string? AbleToComplete { get; set; }

    [Column("temp_12")]
    public string? TeleHealth { get; set; }

    [Column("dementia_risks")]
    public string? DementiaRisks { get; set; }

    [Column("dementia_conv")]
    public string? DementiaConv { get; set; }

    [Column("alcohol_q")]
    public string? AlcoholQ { get; set; }

    [Column("alcohol_time")]
    public string? AlcoholTime { get; set; }

    [Column("alcohol_conv")]
    public string? AlcoholConv { get; set; }

    [Column("tobbaco_q")]
    public string? Tobbaco { get; set; }

    [Column("tobbaco_time")]
    public string? TobbacoTime { get; set; }

    [Column("tobbaco_conv")]
    public string? TobbacoConv { get; set; }

    [Column("subst_q")]
    public string? SubstanceOften { get; set; }

    [Column("subst_time")]
    public string? SubstanceCounseling { get; set; }

    [Column("subst_conv")]
    public string? SubstanceConv { get; set; }

    [Column("tr_mental")]
    public string? TrMental { get; set; }

    [Column("tr_psych")]
    public string? TrPsych { get; set; }

    [Column("tr_trauma")]
    public string? Trhistory { get; set; }

    [Column("tr_post_trauma")]
    public string? TrPostTrauma { get; set; }

    [Column("tr_illness")]
    public string? TrIllness { get; set; }

    [Column("tr_accident")]
    public string? TrAccident { get; set; }

    [Column("tr_ph_assault")]
    public string? TrAssault { get; set; }

    [Column("tr_ph_threat")]
    public string? TrThreat { get; set; }

    [Column("tr_sex_threat")]
    public string? TrSexThreat { get; set; }

    [Column("tr_sex_assault")]
    public string? TrSexAssault { get; set; }

    [Column("tr_fright")]
    public string? TrFright { get; set; }

    [Column("tr_fright_witness")]
    public string? TrFrightWitness { get; set; }

    [Column("tr_fright_rel")]
    public string? TrFrightRel { get; set; }

    [Column("tr_withdrawn")]
    public string? TrWithdrawn { get; set; }

    [Column("tr_angry")]
    public string? TrAngry { get; set; }

    [Column("tr_mood")]
    public string? TrMood { get; set; }

    [Column("addon_maladaptive")]
    public string? Maladaptive { get; set; }

    [Column("addon_emotional")]
    public string? Emotional { get; set; }

    [Column("addon_sentinel")]
    public string? Sentinel { get; set; }

    [Column("addon_lang")]
    public string? Language { get; set; }

    [Column("fu_obj_prevention")]
    public string? FuObjPrevention { get; set; }

    [Column("fu_obj_treatment")]
    public string? FuObjTreatment { get; set; }

    [Column("lbl_1")]
    public string? NoteType { get; set; }

    [Column("temp_16")]
    public string? Alcohol { get; set; }

    [Column("temp_17")]
    public string? Substance { get; set; }

    [Column("temp_18")]
    public string? AdvancedCarePlaning { get; set; }

    [Column("temp_19")]
    public string? AdvancedCarePlaningDiscussion { get; set; }

    [Column("temp_20")]
    public string? LatestBimsScore { get; set; }

    [Column("temp_21")]
    public string? RationaleForSeeingLowBims { get; set; }

    [Column("temp_22")]
    public string? RationalForSeeingTwiceInWeek { get; set; }

    [Column("temp_23")]
    public string? RationaleForSeeingOtherProvider { get; set; }

    [Column("temp_30")]
    public string? TrSummary { get; set; }

    [Column("provider_type")]
    public string? ProviderType { get; set; }

    [Column("DateOfBirth")]
    public DateTime? DateOfBirth { get; set; }
}
