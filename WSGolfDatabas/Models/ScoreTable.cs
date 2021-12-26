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
        public WeatherTable WeatherId { get; set; }// 
        public CourseTable CourseId { get; set; }  // <-- EF kommer att länka automatiskt då
        // tänk på att söka efter exempelvis väder i vädertabellen först innan du stoppar in den i Score
        // 1 - Väder = Molnigt, 20 grader
        // 2 - Sök på väder om Molnigt 20 grader finns
        // 3 - om det finns lagra det i en variabel
        // 4 - om det inte finns, skapa en ny instans av WeatherTable med molnigt, 20 grader
        // 5 - spara instansen (antingen från sökningen eller den nya) i din scoreTable
        // 6 - gör samma sak med Course
        // Det gör du, när du gjort den första så är det lätt sen. Har du gjort övningen med att skapa superhjältar och deras krafter?
        // där gör man så :)
        // Absolut, är online resten av dan och skriver betyg :)
    }
}
