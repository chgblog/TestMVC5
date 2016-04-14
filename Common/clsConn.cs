using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.ViewModels;

namespace Common
{
    public class clsConn
    {
        public class ConnDBContext : DbContext
        {
            public ConnDBContext()
                : base("ConnectionString")
            {

            }

            public DbSet<Exam_e_CourseInfo> Exam_e_CourseInfo { get; set; }

            //public DbSet<DynamicModel> Exam_e_CourseInfo { get; set; }
        }

    }
}
