using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DanialImani1370.Models
{
    public class Person
    {
        [DisplayName("شماره")]
        public int Id { get; set; }
        [DisplayName("نام")]
        public string FirstName { get; set; }
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }
        [DisplayName("سن")]
        public int Age { get; set; } 
        [DisplayName("سمت")]
        public string Job { get; set; }
        [DisplayName("جنسیت")]
        public string Sex { get; set; }
        [DisplayName("تحصیلات")]
        public string Education { get; set; }
        [DisplayName("تاریخ تولد")]
        public string BrithDate { get; set; }

    }
}
