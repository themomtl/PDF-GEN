using GenPDF.DropBox;
using GenPDF.Exceptions;
using GenPDF.Models;
using GenPDF.Utils;
using PdfGenAPI;
using PdfGenAPI.Views;

namespace GenPDF.Data
{
    internal class BimsData(IDropBoxService dropBox, ContextFactory contextFactory) : IBimsData
    {
        private readonly IDropBoxService _dropBox = dropBox;
        private readonly ContextFactory _contextFactory = contextFactory;

        public BimsModel Get(BimsTable _data, string state)
        {
            if (_data.Signature == null || _data.Signature == "")
            {
                throw new NoSignatureException("no signature");
            }

            string sig = _dropBox.DownloadImage(state, _data.Signature, 1);

            return new BimsModel
            {
                DOB = Convert.ToDateTime(_data.DateOfBirth).ToShortDateString(),
                Facility = _data.FacilityName,
                ServiceDate = Convert.ToDateTime(_data.BimsDate).ToShortDateString(),
                PatientName = _data.ClientName,
                QNumberOfWords = _data.QNumberOfWords,
                QYearNow = _data.QYearNow,
                QMonthNow = _data.QMonthNow,
                QDayNow = _data.QDayNow,
                QRecallFirst = _data.QRecallFirst,
                QRecallSecond = _data.QRecallSecond,
                QRecallThird = _data.QRecallThird,
                SummaryScore = _data.SummaryScore,
                ProviderType = _data.ProviderType,
                Signature = new ConvertBase().Start(sig),
                Provider = _data.Provider,
            };
        }
    }
}

public interface IBimsData
{
    BimsModel Get(BimsTable _data, string state);
}
