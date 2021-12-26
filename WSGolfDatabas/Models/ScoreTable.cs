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
        public WeatherTable WeatherId { get; set; }
        public CourseTable CourseId { get; set; } 
    }
}
