namespace Dev4Fun_Sem3_eProject.Models
{
    public class AppliedJob
    {
        public int id { get; set; }
        public int JobId { get; set; }
        public string CandidateEmail { get; set; }       
        public string CandidateName{ get; set; }
        public string CandidateThumbnail{ get; set; }
        public string CandidatePhone{ get; set; }
        public string CandidateLocation{ get; set; }
        public string CandidateCv{ get; set; }
        public string Messenger { get; set; }
        public int MentorId { get; set; }
        public int Status { get; set; }    //0 waiting / 1 accept / 2 done / 3 delete
        public string InterviewDate{ get; set; }
    }
}
