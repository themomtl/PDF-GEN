namespace GenPDF.Models
{
    public class BimsModel : BaseNoteModel
    {
        public string? QNumberOfWords { get; set; }
        public string? QYearNow { get; set; }
        public string? QMonthNow { get; set; }
        public string? QDayNow { get; set; }
        public string? QRecallFirst { get; set; }
        public string? QRecallSecond { get; set; }
        public string? QRecallThird { get; set; }
        public string? SummaryScore { get; set; }
        public string? Singnature { get; set; }
    }
}
