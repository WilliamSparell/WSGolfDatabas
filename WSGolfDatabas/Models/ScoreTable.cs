using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSGolfDatabas.Models
{
    internal class ScoreTable
    {
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public int WeatherId { get; set; }
        public int CourseId { get; set; }

    }
}
