using Microsoft.EntityFrameworkCore;
using R2hReportCardService.Models;

namespace  R2hReportCardService.Services
{
  public class R2hReportCardContext : DbContext
  {
        public virtual DbSet<MentorReportCard> MentorReportCard { get; set; }

        //constructor
        public R2hReportCardContext(DbContextOptions<R2hReportCardContext> options)
        :base(options)
        {

        }
  }
}