using GenPDF.DropBox;
using GenPDF.Exceptions;
using GenPDF.Models;
using GenPDF.Utils;
using PdfGenAPI;
using PdfGenAPI.Views;

namespace GenPDF.Data
{
    public class EvalProgData : IEvalProgData
    {
        private readonly IDropBoxService _dropBox;
        private readonly ContextFactory _contextFactory;

        public EvalProgData(IDropBoxService dropBox, ContextFactory contextFactory)
        {
            _dropBox = dropBox;
            _contextFactory = contextFactory;
        }

        public EvalProgModel Get(EvalTable _data, string state)
        {
            if (_data.Signature == null || _data.Signature == "")
            {
                throw new NoSignatureException("no signature");
            }

            string signature = _data.Signature;
            string sig = _dropBox.DownloadImage(state, signature, 1);

            _data.Signature = sig;

            return new EvalProgModel
            {
                EndTime = Convert.ToDateTime(_data.EndTime).ToShortTimeString(),
                PatientName = _data.ClientName,
                DOB = Convert.ToDateTime(_data.DateOfBirth).ToShortDateString(),

                Facility = _data.FacilityName,
                CptAddon = _data.CptAddon,
                CptCode = _data.CPTCode,
                StartTime = Convert.ToDateTime(_data.StartTime).ToShortTimeString(),
                ServiceDate = Convert.ToDateTime(_data.SesDate).ToShortDateString(),
                Service = _data.ServiceTap,
                DxCodes = GetDXCodeList(_data),
                SymptomsPhysical = _data.SymptomsPhysical,
                SymptomsPsych = _data.SymptomsPsych,
                DementiaRisks = _data.DementiaRisks,
                Functional = _data.Functional,
                StressorsChanges = _data.StressorsChanges,
                Therapeutic = _data.Therapeutic,
                FuObjPrevention = _data.FuObjPrevention,
                FuObjTreatment = _data.FuObjTreatment,
                Psychotherapeutic = _data.Psychotherapeutic,
                Result = _data.Psychotherapeutic,
                Improved = _data.ResultsImproved,
                Identified = _data.ResultsIdentified,
                Reduced = _data.ResultsReduced,
                Disposition = _data.Disposition,
                TeleHealth = _data.TeleHealth,
                Reason = _data.InitialReason,
                Appearance = _data.Appearance,
                Behavior = _data.Behavior,
                Affect = _data.Affect,
                Speech = _data.Speech,
                ThoughtProcess = _data.ThoughtProc,
                ThoughtContent = _data.ThoughtCon,
                Hallucination = _data.Halucinations,
                Delusion = _data.Delusions,
                SelfPerception = _data.SelefPerception,
                Orientation = _data.Orientation,
                Cognitive = _data.Cognitive,
                Memory = _data.Memory,
                Judgment = _data.Judgment,
                RiskFactor = _data.RiskFactor,
                RatCognitive = GetRat(_data.RatCognitive),
                RatTreatment = GetRat(_data.RatTreatment),
                RatSocial = GetRat(_data.RatSocial),
                RatBehave = GetRat(_data.RatBehave),
                RatPsych = GetRat(_data.RatPsych),
                RatEmotion = GetRat(_data.RatEmotion),
                RatInterfer = GetRat(_data.RatInterfer),
                RatDeter = GetRat(_data.RatDeter),
                Alcohol = _data.Alcohol,
                AlcoholTime = GetAlcoholTobbacoSub(_data.AlcoholTime),
                AlcoholQ = _data.AlcoholQ,
                AlcoholConv = _data.AlcoholConv,
                Tobbaco = _data.Tobbaco,
                TobbacoTime = GetAlcoholTobbacoSub(_data.TobbacoTime),
                TobbacoConv = _data.TobbacoConv,
                Substance = _data.Substance,
                SubstanceConv = _data.SubstanceConv,
                SubstanceCounseling = GetAlcoholTobbacoSub(_data.SubstanceCounseling),
                SubstanceOften = _data.SubstanceOften,
                Goals = _data.TheaGoals,
                Treatment = _data.Treatment,
                Prevention = _data.Prevention,
                Modalities = _data.Modalities,
                Recommendations = _data.Recommendations,
                RecoNotes = _data.RecoNotes,
                SesFam = _data.SesFam,
                SesGroup = _data.SesGroup,
                Notes = _data.Notes,
                Frequency = _data.Frequency,
                Signature = new ConvertBase().Start(_data.Signature),
                Provider = _data.Provider,
                TrAccident = _data.TrAccident,
                TrAngry = _data.TrAngry,
                TrAssault = _data.TrAssault,
                TrFright = _data.TrFright,
                TrFrightRel = _data.TrFrightRel,
                TrFrightWitness = _data.TrFrightWitness,
                TrHistory = _data.Trhistory,
                TrIllness = _data.TrIllness,
                TrMental = _data.TrMental,
                TrMood = _data.TrMood,
                TrPostTrauma = _data.TrPostTrauma,
                TrPsych = _data.TrPsych,
                TrSexAssault = _data.TrSexAssault,
                TrSexThreat = _data.TrSexThreat,
                TrSummary = _data.TrSummary,
                TrThreat = _data.TrThreat,
                TrWithdrawn = _data.TrWithdrawn,
                ProviderType = _data.ProviderType,
            };
            static List<string> GetDXCodeList(dynamic _data)
            {
                List<string> dxs = new List<string>();

                if (_data.DXCode != "")
                {
                    dxs.Add((string)_data.DXCode);
                }
                if (_data.DXCode2 != "")
                {
                    dxs.Add((string)_data.DXCode2);
                }
                if (_data.DXCode3 != "")
                {
                    dxs.Add((string)_data.DXCode3);
                }
                if (_data.DXCode4 != "")
                {
                    dxs.Add((string)_data.DXCode4);
                }
                return dxs;
            }
            static string? GetRat(string? tr)
            {
                if (tr == "TRUE" || tr == "1" || tr == "-1")
                {
                    return "1";
                }
                return "0";
            }
            static string? GetAlcoholTobbacoSub(string? alcoholTobbacoSub)
            {
                if (alcoholTobbacoSub == "-1" || alcoholTobbacoSub == "0")
                {
                    return "0";
                }
                return alcoholTobbacoSub;
            }
        }
    }
}

public interface IEvalProgData
{
    EvalProgModel Get(EvalTable _data, string state);
}
