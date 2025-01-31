using GenPDF.DropBox;
using GenPDF.Exceptions;
using GenPDF.Utils;
using PdfGenAPI.Models;
using PdfGenAPI.Views;

namespace PdfGenAPI.Data;

public class AimsData(IDropBoxService dropBox) : IAimsData
{
    public AimsModel Get(AimsTable _data, string state)
    {
        if (_data.AimsSignature == null || _data.AimsSignature == "")
        {
            throw new NoSignatureException("there is no signature");
        }
        var sig = dropBox.DownloadImage(state, _data.AimsSignature, 2);

        char? muscle = _data.FacialMuscle?.ToArray()[0];
        char? lips = _data.FacialLips?.ToArray()[0];
        char? jaw = _data.FacialJaw?.ToArray()[0];
        char? tongue = _data.FacialTongue?.ToArray()[0];
        char? upper = _data.ExtremityUpper?.ToArray()[0];
        char? lower = _data.ExtremityLower?.ToArray()[0];
        char? neck = _data.TrunkNeck?.ToArray()[0];
        char? severity = _data.OverallSeverity?.ToArray()[0];
        char? incap = _data.OverallIncapacity?.ToArray()[0];
        char? aware = _data.OverallAwareness?.ToArray()[0];

        return new AimsModel
        {
            PatientName = _data.PatientName,
            Provider = _data.ProviderName,
            Facility = _data.FacilityName,
            AimsDate = _data.AimsDate.ToShortDateString(),
            Signature = new ConvertBase().Start(sig),
            MedicationOne = _data.MedicationOne,
            MedicationOneDosage = _data.MedicationOneDosage,
            MedicationTwo = _data.MedicationTwo,
            MedicationTwoDosage = _data.MedicationTwoDosage,
            MedicationThree = _data.MedicationThree,
            MedicationThreeDosage = _data.MedicationThreeDosage,
            FacialMuscales = muscle == null ? null : (int)char.GetNumericValue((char)muscle),
            FacialLips = lips == null ? null : (int)char.GetNumericValue((char)lips),
            FacialJaw = jaw == null ? null : (int)char.GetNumericValue((char)jaw),
            FacialTongue = tongue == null ? null : (int)char.GetNumericValue((char)tongue),
            ExtremityUpper = upper == null ? null : (int)char.GetNumericValue((char)upper),
            ExtremityLower = lower == null ? null : (int)char.GetNumericValue((char)lower),
            TrunkNeck = neck == null ? null : (int)char.GetNumericValue((char)neck),
            OverallSeverity = severity == null ? null : (int)char.GetNumericValue((char)severity),
            OverallIncopacitation = incap == null ? null : (int)char.GetNumericValue((char)incap),
            OverallAwareness = aware == null ? null : (int)char.GetNumericValue((char)aware),
            DentalProblem = _data.DentalProblems,
            DentalDentures = _data.DentalDentures,
            Comment = _data.AimsComments,
        };
    }
}

public interface IAimsData
{
    AimsModel Get(AimsTable _data, string state);
}
