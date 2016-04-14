using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Model3 : IModel
    {
        [Key]
        public int ModelID { get; set; }
        public string Name { get; set; }

        public string Sex { get; set; }
    }
}
