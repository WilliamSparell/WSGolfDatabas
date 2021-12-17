using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSGolfDatabas.Models
{
    internal class CourseTable
    {
        public DateTime Date { get; set; }
        public string Weather { get; set; }
        public string GolfCourse { get; set; }
        public int Score { get; set; }
    }
}
