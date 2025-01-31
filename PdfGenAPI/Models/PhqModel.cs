namespace GenPDF.Models
{
    public class PhqModel : BaseNoteModel
    {
        
        public string? Date { get; set; }
        public string? Interest { get; set; }
        public string? Down { get; set; }
        public string? Sleep { get; set; }
        public string? Energy { get; set; }
        public string? Apettite { get; set; }
        public string? Feel_bad { get; set; }
        public string? Concentrate { get; set; }
        public string? Slow_move { get; set; }
        public string? Thoughts { get; set; }
        public string? Difficult { get; set; }
        public string? OftenLonely { get; set; }
        public int Sc_1 { get; set; }
        public int Sc_2 { get; set; }
        public int Sc_3 { get; set; }
        public int Sc_4 { get; set; }
        public int Sc_total { get; set; }
    }
}
