using Common.ViewModels;
using System.Collections.Generic;
using System.Data.Entity;

namespace Test1.Models
{
    public class CeShi
    {
        public int ID { get; set; }
        public int NianLing { get; set; }
        public string[] XingMing { get; set; }

        public IList<Exam_e_CourseInfo> CourseList { get; set; }

        public CeShi()
        {
            CourseList = new List<Exam_e_CourseInfo>();
        }
    }

    public class CeShiDBContext : DbContext
    {
        public CeShiDBContext()
            : base("ConnectionString")
        {

        }

        public DbSet<CeShi> CeShis { get; set; }
    }
}