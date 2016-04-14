using Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TestModel<TEntity> where TEntity : IModel, new()
    {
        private DynamicDbContext<TEntity> db = new DynamicDbContext<TEntity>();

        public void Add(dynamic model)
        {
            model.Name = "hello world!";
            db.Set<TEntity>().Add(model);
            db.SaveChanges();
        }
    }
}
