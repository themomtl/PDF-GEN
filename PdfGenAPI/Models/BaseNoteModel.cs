namespace GenPDF.Models
{
    public class BaseNoteModel
    {
        public string? PatientName { get; set; }
        public string? DOB { get; set; }
        public string? CptCode { get; set; }
        public string? CptAddon { get; set; }
        public string? Facility { get; set; }
        public string? ServiceDate { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? Maladaptive { get; set; }
        public string? Emotional { get; set; }
        public string? Sentinel { get; set; }
        public string? Language { get; set; }
        public byte[]? Signature { get; set; }
        public string? Provider { get; set; }
        public string? ProviderType { get; set; }
    }
}
