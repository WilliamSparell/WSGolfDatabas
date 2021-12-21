using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSGolfDatabas.Database;
using WSGolfDatabas.Models;
using static WSGolfDatabas.utiles.OutputHelper;

namespace WSGolfDatabas.utiles
{
    internal class CRUDHelper
    {
        public static ScoreTable FindOrCreateRound(DateTime date, int score, int weatherId, int courseId)
        {
            using (var db = new GolfContext())
            {
                var round = db.Scores.
                FirstOrDefault(

                p => p.Date == date // Sök på datum

                );
                if (round == null) // om rundan inte finns, skapa den
                {
                    round = new ScoreTable{ Date = date, Score = score, WeatherId = weatherId, CourseId = courseId };
                    db.Scores.Add(round);
                    db.SaveChanges();
                    Console.WriteLine("rundan är nu skapad!");
                }
                else
                    Console.WriteLine("Datumet finns redan inlagd");

                return round;
            }
        }
        public static ScoreTable FindAndDeleteRound(DateTime date)
        {
            using (var db = new GolfContext())
            {
                var round = db.Scores.
                FirstOrDefault(

                p => p.Date == date 

                );
                if (round != null) // om rundan finns, radera den
                {
                    db.Scores.Remove(round);
                    db.SaveChanges();
                    Console.WriteLine("rundan är nu Borta!");
                }
                else
                    Console.WriteLine("Hittade ingen runda med det datumet");

                return round;
            }
        }
        public static ScoreTable FindAndUpdateRound(DateTime date)
        {
            using (var db = new GolfContext())
            {
                var round = db.Scores.
                FirstOrDefault(

                    p => p.Date == date

                );
                if (round != null) // om personen finns, ta bort den
                {
                    Update(round);
                    db.Scores.Update(round);
                    db.SaveChanges();
                    Console.WriteLine("Personen är nu uppdaterad");
                }
                return round;
            }
        }

        private static void Update(ScoreTable score)
        {
            Console.WriteLine("Vad vill du uppdatera?");
            Console.WriteLine("1. Score");
            Console.WriteLine("2. Väder");
            Console.WriteLine("3. Bana");
            string input = Console.ReadLine();

            if (input == "1")
            {
                int.TryParse(WriteAndInput("Skriv in nya score: "), out int updated);
                score.Score = updated;
            }
            if (input == "2")
            {
                int.TryParse(WriteAndInput("Skriv in nya score: "), out int updated);
                score.WeatherId = updated;
            }
            if (input == "3")
            {
                int.TryParse(WriteAndInput("Skriv in nya score: "), out int updated);
                score.CourseId = updated;
            }

        }
    }
}
