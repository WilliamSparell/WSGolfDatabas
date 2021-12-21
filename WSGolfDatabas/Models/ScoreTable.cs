using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSGolfDatabas.Models
{
    public class ScoreTable
    {
        [Key]
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public int WeatherId { get; set; }
        public int CourseId { get; set; }

    }
}
