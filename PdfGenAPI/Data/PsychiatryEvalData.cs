using GenPDF.DropBox;
using GenPDF.Exceptions;
using GenPDF.Utils;
using Microsoft.EntityFrameworkCore;
using PdfGenAPI.Models;
using PdfGenAPI.Views;

namespace PdfGenAPI.Data;

public class PsychiatryEvalData(
    IDropBoxService dropBox,
    ContextFactory contextFactory,
    IServiceProvider serviceProvider
) : IPsychiatryEvalData
{
    private readonly IDropBoxService _dropBox = dropBox;
    private readonly ContextFactory _contextFactory = contextFactory;

    public PsychiatryEvalModel Get(PsychiatryEvalTable table, string state)
    {
        var history = new List<HistoryModel>();
        var illnessExamWordCount = 0;
        illnessExamWordCount += table.PhysicallExam == null ? 0 : table.PhysicallExam.Length;

        var context =
            _contextFactory.GetContext(state) ?? throw new Exception("Dont have this context");
        var appCo = context.Set<AppPathTable>().FirstOrDefault();
        var match = context
            .Set<PsychiatryEvalTable>()
            .Where(x =>
                x.SupcarePatientId == table.SupcarePatientId && x.SessionDate <= table.SessionDate
            )
            .OrderByDescending(x => x.SessionDate)
            .Take(5);
        foreach (var item in match)
        {
            if (item.CurrentIllness != null)
            {
                illnessExamWordCount += item.CurrentIllness.Length;
            }

            history.Add(
                new HistoryModel
                {
                    Illness = item.CurrentIllness,
                    Date = Convert.ToDateTime(item.SessionDate).ToShortDateString(),
                }
            );
        }

        if (table.Signature == null || table.Signature == "")
        {
            throw new NoSignatureException("no signature");
        }
        string sig = _dropBox.DownloadImage(state, table.Signature, 2);
        //
        var utilsContext = (DbContext)serviceProvider.GetService(typeof(TSC_Utilities));
        var dxOne = utilsContext.Set<DxCodeTable>().FirstOrDefault(x => x.DxCodes == table.DxCode);
        var dxTwo = utilsContext.Set<DxCodeTable>().FirstOrDefault(x => x.DxCodes == table.DxCode2);
        var dxThree = utilsContext
            .Set<DxCodeTable>()
            .FirstOrDefault(x => x.DxCodes == table.DxCode3);
        var dxFour = utilsContext
            .Set<DxCodeTable>()
            .FirstOrDefault(x => x.DxCodes == table.DxCode4);

        var provider =
            from p in context.Set<ProviderTable>().Where(x => x.ProviderId == table.ProviderId)
            join pt in context.Set<ProviderTypeTable>() on p.ProviderType equals pt.ProviderTypeId
            select new { pt.ProviderType };

        var ProviderType = provider.FirstOrDefault().ProviderType;

        return new PsychiatryEvalModel()
        {
            PatientName = table.ClientName,
            DOB = Convert.ToDateTime(table.DateOfBirth).ToShortDateString(),
            Facility = table.FacilityName,
            StartTime = Convert.ToDateTime(table.StartTime).ToShortTimeString(),
            EndTime =
                table.EndTime == null
                    ? null
                    : Convert.ToDateTime(table.EndTime).ToShortTimeString(),
            ServiceDate = Convert.ToDateTime(table.SessionDate).ToShortDateString(),
            CptCode = table.CptCode,
            CptAddon = table.CptAddon,
            Signature = new ConvertBase().Start(sig),
            Provider = table.Provider,
            ProviderType = ProviderType ?? "",

            Complaints = table.Complaints,
            Source = table.Source,
            Allergies = table.Allergies,

            HistoryList = history,
            HistoryWordCount = illnessExamWordCount,

            PhysicallExam = table.PhysicallExam,
            //ROS Review
            NpPsych = table.NpPsych,
            Temp100 = table.Temp100,

            NpEndocrine = table.NpEndocrine,
            Temp101 = table.Temp101,

            NpRespiratory = table.NpRespiratory,
            Temp102 = table.Temp102,

            NpGu = table.NpGu,
            Temp103 = table.Temp103,

            NpNeuro = table.NpNeuro,
            Temp104 = table.Temp104,

            NpConstitutional = table.NpConstitutional,
            Temp105 = table.Temp105,

            NpAmbulation = table.NpAmbulation,
            Temp106 = table.Temp106,

            NpAdl = table.NpAdl,
            Temp107 = table.Temp107,

            NpMusculoskeletal = table.NpMusculoskeletal,
            Temp108 = table.Temp108,

            NpCardio = table.NpCardio,
            NpSkin = table.NpSkin,
            NpGi = table.NpGi,
            NpHematological = table.NpHematological,

            NpOther = table.NpOther,
            NpOtherText = table.NpOtherText,
            //Labs Ordered
            LabsOrderedOne = table.LabsOrderedOne,
            LabsOrderedTwo = table.LabsOrderedTwo,
            LabsOrderedThree = table.LabsOrderedThree,
            LabsOrderedFour = table.LabsOrderedFour,
            //labs reviewed
            LabsReviewedOne = table.LabsReviewedOne,
            LabsReviewOrderedOne = table.LabsReviewOrderedOne,
            LabsReviewedOneDate = table.LabsReviewDateOne,
            LabsReviewFindingsOne = table.LabsReviewFindingsOne,

            LabsReviewedTwo = table.LabsReviewedTwo,
            LabsReviewOrderedTwo = table.LabsReviewOrderedTwo,
            LabsReviewedTwoDate = table.LabsReviewDateTwo,
            LabsReviewFindingsTwo = table.LabsReviewFindingsTwo,

            LabsReviewedThree = table.LabsReviewedThree,
            LabsReviewOrderedThree = table.LabsReviewOrderedThree,
            LabsReviewedThreeDate = table.LabsReviewDateThree,
            LabsReviewFindingsThree = table.LabsReviewFindingsThree,

            LabsReviewedFour = table.LabsReviewedFour,
            LabsReviewOrderedFour = table.LabsReviewOrderedFour,
            LabsReviewedFourDate = table.LabsReviewDateFour,
            LabsReviewFindingsFour = table.LabsReviewFindingsFour,
            //Collab
            PhoneReview = table.PhoneReview,
            PhoneReviewDoc = table.PhoneReviewDoc,

            PhoneConversation = table.PhoneConversation,
            PhoneWith = table.PhoneWith,
            PhoneWithDoc = table.PhoneWithDoc,
            PhoneConvDoc = table.PhoneConvDoc,
            //Doc Review
            DocReview = table.DocReview,
            DocRevName = table.DocRevName,
            DocFindings = table.DocFindings,
            DocReviewDoc = table.DocReviewDoc,
            DocRevNameDoc = table.DocRevNameDoc,
            DocRevFingingsDoc = table.DocRevFindingsDoc,

            //Diagnosis
            
            DxCode = dxOne?.DxCodesDescription,
            Dx1Severity = table.Dx1Severity,
            Dx1Status = table.Dx1Status,
            Dx1risk = table.Dx1Risk,

            
            DxCode2 = dxTwo?.DxCodesDescription,
            Dx2Severity = table.Dx2Severity,
            Dx2Status = table.Dx2Status,
            Dx2risk = table.Dx2Risk,

            
            DxCode3 = dxThree?.DxCodesDescription,
            Dx3Severity = table.Dx3Severity,
            Dx3Status = table.Dx3Status,
            Dx3risk = table.Dx3Risk,

            
            DxCode4 = dxFour?.DxCodesDescription,
            Dx4Severity = table.Dx4Severity,
            Dx4Status = table.Dx4Status,
            Dx4risk = table.Dx4Risk,

            Temp113 = table.Temp113,
            Temp114 = table.Temp114,
            Temp115 = table.Temp115,
            Temp116 = table.Temp116,
            Temp117 = table.Temp117,
            Temp118 = table.Temp118,
            Temp119 = table.Temp119,
            Temp120 = table.Temp120,

            
            CondOneCourse = table.CondOneCourse,
            CondTwoCourse = table.CondTwoCourse,
            CondThreeCourse = table.CondThreeCourse,
            CondFourCourse = table.CondFourCourse,

            
            CondOnePlan = table.CondOnePlan,
            CondTwoPlan = table.CondTwoPlan,
            CondThreePlan = table.CondThreePlan,
            CondFourPlan = table.CondFourPlan,
            
            MedicationOne = table.MedicationOne,
            MedicationTwo = table.MedicationTwo,
            MedicationThree = table.MedicationThree,
            MedicationFour = table.MedicationFour,

            MedicationOneDosage = table.MedicationOneDosage,
            MedicationOneDosageChange = table.MedicationOneDosageChange,

            MedicationTwoDosage = table.MedicationTwoDosage,
            MedicationTwoDosageChange = table.MedicationTwoDosageChange,

            MedicationThreeDosage = table.MedicationThreeDosage,
            MedicationThreeDosageChange = table.MedicationThreeDosageChange,

            MedicationFourDosage = table.MedicationFourDosage,
            MedicationFourDosageChange = table.MedicationFourDosageChange,
            Temp109 = table.Temp109,
            Temp110 = table.Temp110,
            Temp111 = table.Temp111,
            Temp112 = table.Temp112,
            //GDR
            GDR = table.GDR,
            GdrText = table.GdrText,
            //Danger
            AimsDate = table.AimsDate,
            Danger = table.Danger,
            ContSrvce = table.ContSvce,
            NpAims = table.NpAims,

            TeleHealth = table.TeleHealth,
            AppCo = appCo?.AppCo,
            SupcareFacId = table.SupcareFacId,
        };
    }
}

public interface IPsychiatryEvalData
{
    PsychiatryEvalModel Get(PsychiatryEvalTable table, string state);
}
