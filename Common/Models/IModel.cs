using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public abstract class IModel
    {
        [Key]
        int ModelID { get; set; }
        string Name { get; set; }
    }
}
