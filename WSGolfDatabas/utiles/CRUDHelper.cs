using WSGolfDatabas.Database;
using WSGolfDatabas.Models;
using static WSGolfDatabas.utiles.OutputHelper;

namespace WSGolfDatabas.utiles
{
    internal class CRUDHelper
    {
        public static void FindOrCreateRound(DateTime date, int score, string weather, string course)
        {
            using (var db = new GolfContext())
            {
                var existingCourse = db.Courses.
                FirstOrDefault(
                p => p.GolfCourse == course
                );
                if (existingCourse == null) existingCourse = new CourseTable { GolfCourse = course };

                var existingWeather = db.Weathers.
                FirstOrDefault(
                p => p.Weather == weather
                );
                if (existingWeather == null) existingWeather = new WeatherTable { Weather = weather };

                var round = new ScoreTable { Date = date, Score = score, WeatherId = existingWeather, CourseId = existingCourse };
                db.Scores.Add(round);
                db.SaveChanges();
            }
        }
        public static ScoreTable FindAndDeleteRound()
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
                return round;
            }
        }
        //public static ScoreTable FindAndUpdateRound(DateTime date)
        //{
        //    using (var db = new GolfContext())
        //    {
        //        var round = db.Scores.
        //        FirstOrDefault(

        //            p => p.Date == date

        //        );
        //        if (round != null) // om personen finns, ta bort den
        //        {
        //            Update(round);
        //            db.Scores.Update(round);
        //            db.SaveChanges();
        //            Console.WriteLine("Personen är nu uppdaterad");
        //        }
        //        return round;
        //    }
        //}

        //private static void Update(ScoreTable score)
        //{
        //    Console.WriteLine("Vad vill du uppdatera?");
        //    Console.WriteLine("1. Score");
        //    Console.WriteLine("2. Väder");
        //    Console.WriteLine("3. Bana");
        //    string input = Console.ReadLine();

        //    if (input == "1")
        //    {
        //        int.TryParse(WriteAndInput("Skriv in nya score: "), out int updated);
        //        score.Score = updated;
        //    }
        //    if (input == "2")
        //    {
        //        string updated = WriteAndInput("Skriv in nya score: ");
        //        score.WeatherId = updated;
        //    }
        //    if (input == "3")
        //    {
        //        int.TryParse(WriteAndInput("Skriv in nya score: "), out int updated);
        //        score.CourseId = updated;
        //    }

        //}
    }
}
