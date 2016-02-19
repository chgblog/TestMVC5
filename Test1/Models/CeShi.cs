using System.Data.Entity;

namespace Test1.Models
{
    public class CeShi
    {
        public int ID { get; set; }
        public int NianLing { get; set; }
        public string XingMing { get; set; }
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