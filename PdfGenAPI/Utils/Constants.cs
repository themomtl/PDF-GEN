namespace GenPDF.Utils
{
    public static class Constants
    {
        public const int PsychologyId = 1;
        public const int PsychiatryId = 2;
        public const int PsychologyVersion = 2;
        public const int PsychiatryVersion = 3;
        public const string Psychology = "Psychology";
        public const string PsychologyLower = "psychology";
        public const string Psychiatry = "Psychiatry";
        public const string PsychiatryLower = "psychiatry";
        public const string Evaluation = "Evaluation";
        public const string EvaluationLower = "evaluation";
        public const string FollowUp = "Followup";
        public const string FollowUpLower = "followup";
        public const string Bims = "Bims";
        public const string BimsLower = "bims";
        public const string BIMS = "BIMS";
        public const string Phq9 = "Phq9";
        public const string Phq9Lower = "phq9";
        public const string Aims = "Aims";
        public const string AimsLower = "aims";
        public const string PsychologyV2Table = "tbl_app_timesheets_raw_2";
        public const string PsychiatryV3Table = "tbl_app_timesheets_Psych_raw_3";
        public const string PsychiatryV1Table = "tbl_app_timesheets_Psych_raw";
        public const string Phq9Table = "tbl_app_phq9";
        public const string AimsTable = "tbl_app_aims";
        public const string BimsV2Table = "tbl_app_bims_2";
        public const string EvalView = "vw_pra_timesheets";
        public static readonly TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById(
            "Eastern Standard Time"
        );

        //static function to return the current time in eastern time zone

        public static class HttpContextItems
        {
            public const string User = "User";
            public const string States = "states";
            public const string ServiceTypeId = "serviceTypeId";
            public const string ServiceType = "serviceType";
        }
    }
}
