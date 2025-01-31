using GenPDF.DropBox;
using GenPDF.Exceptions;
using GenPDF.Models;
using GenPDF.Utils;
using PdfGenAPI;
using PdfGenAPI.Views;

namespace GenPDF.Data
{
    public class PhqData : IPhqData
    {
        private readonly IDropBoxService _dropBox;
        private readonly ContextFactory _contextFactory;

        public PhqData(IDropBoxService dropBox, ContextFactory contextFactory)
        {
            _dropBox = dropBox;
            _contextFactory = contextFactory;
        }

        public PhqModel Get(PhqTable data, string state)
        {
            if (data.Signature == null || data.Signature == "")
            {
                throw new NoSignatureException("no signature");
            }
            string signature = data.Signature;
            int serviceType = data.ServiceType switch
            {
                null or "1" => ServiceType.PSYCHOLOGY,
                "2" => ServiceType.PSYCHIATRY,
                _ => throw new Exception(),
            };

            string sig = _dropBox.DownloadImage(state, signature, serviceType);

            data.Signature = sig;

            return new PhqModel
            {
                DOB = Convert.ToDateTime(data.DateOfBirth).ToShortDateString(),
                PatientName = data.ClientName ?? null,
                Date = Convert.ToDateTime(data.Session_date).ToShortDateString(),
                Interest = data.Interest,
                Down = data.Down,
                Sleep = data.Sleep,
                Energy = data.Energy,
                Feel_bad = data.Feel_bad,
                Apettite = data.Apettite,
                Concentrate = data.Concentrate,
                Slow_move = data.Slow_move,
                Thoughts = data.Thoughts,
                Difficult = data.Difficult,
                Sc_1 = data.Sc_1,
                Sc_2 = data.sc_2,
                Sc_3 = data.Sc_3,
                Sc_4 = data.sc_4,
                Sc_total = data.Sc_total,
                OftenLonely = data.OftenLonely,
                Signature = new ConvertBase().Start(data.Signature),
                Provider = data.Provider,
                ProviderType = data.ProviderType,
                Facility = data.FacilityName,
            };
        }
    }
}

public interface IPhqData
{
    PhqModel Get(PhqTable data, string state);
}
