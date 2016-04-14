using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class DynamicDbContext<TEntity> : DbContext
        where TEntity : IModel, new()
    {
        public DynamicDbContext()
            : base("name=ConnectionString")
        {
        }
        /*
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Model1>().HasKey(t => t.ModelID);
            //modelBuilder.Entity<Model2>().HasKey(t => t.ID);
            modelBuilder.Configurations.Add(new EntityTypeConfiguration<TEntity>());

            base.OnModelCreating(modelBuilder);
        }

    }
}
