using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public partial class Exam_e_CourseInfo
    {
        [Key]
        [Display(Name = "课程代码")]
        [StringLength(5, MinimumLength=2)]
        public string CourseCode { get; set; }
        [Required]
        [Display(Name = "课程名称")]
        [StringLength(10, MinimumLength = 2)]
        public string CourseName { get; set; }

        /*
        [Required]
        [Display(Name = "添加时间")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime AddDate { get; set; }
        */
    }
}
