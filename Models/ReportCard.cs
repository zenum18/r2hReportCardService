namespace r2hReportCardService.Models
{
  public class MentorReportCard
  {
    public int mentorReportCardId { get; set; }
    public int studentId { get; set; }
    public int mentorId { get; set; }
    public string mentorType { get; set; }
  }
}