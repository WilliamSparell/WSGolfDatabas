using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSGolfDatabas.Models
{
    public class CourseTable
    {
        [Key]
        public int Id { get; set; }
        public string Weather { get; set; }
        public string GolfCourse { get; set; }
        public int Score { get; set; } // är det betygsättning av själva banan i sig?
    }
}
