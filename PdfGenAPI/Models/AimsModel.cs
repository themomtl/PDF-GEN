using GenPDF.Models;

namespace PdfGenAPI.Models;

public class AimsModel : BaseNoteModel
{
    public string? AimsDate { get; set; }
    public string? MedicationOne { get; set; }
    public string? MedicationOneDosage { get; set; }
    public string? MedicationTwo { get; set; }
    public string? MedicationTwoDosage { get; set; }
    public string? MedicationThree { get; set; }
    public string? MedicationThreeDosage { get; set; }

    public int? FacialMuscales { get; set; }
    public int? FacialLips { get; set; }
    public int? FacialTongue { get; set; }
    public int? FacialJaw { get; set; }
    public int? ExtremityUpper { get; set; }
    public int? ExtremityLower { get; set; }
    public int? TrunkNeck { get; set; }
    public int? OverallSeverity { get; set; }
    public int? OverallIncopacitation { get; set; }
    public int? OverallAwareness { get; set; }
    public string? DentalProblem { get; set; }
    public string? DentalDentures { get; set; }
    public string? Comment { get; set; }
}
