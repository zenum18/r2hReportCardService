using System;

namespace R2hReportCardService.Models
{
  public class MentorReportCard
  {
    public int mentorReportCardId { get; set; }
    public int studentId { get; set; }
    public int mentorId { get; set; }
    public int mentorType { get; set; }
    public DateTime submittedAt { get; set; }
    public int WTRW { get; set; }
    public int IIY { get; set; }
    public int VYT { get; set; }
    public int LIBTYFI { get; set; }
    public int techStrength { get; set; }
    public string TSAdditionalNotes { get; set; }
    public int metWithMentee { get; set; }
    public string additonalNotes { get; set; }
  }
}