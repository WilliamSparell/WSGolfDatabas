using static WSGolfDatabas.utiles.CRUDHelper;
using static WSGolfDatabas.utiles.OutputHelper;


namespace WSGolfDatabas.Menu
{
    internal class MainMenu
    {
        public void StartMenu()
        {
            while (true)
            {
                Write("1. Ny Runda");
                Write("2. Radera runda");
                //Write("3. Lista runda");
                Write("4. Uppdatera runda");
                string input = Console.ReadLine();

                if (input == "1")
                    CreateRound();
                if (input == "2")
                    DeleteRound();
                //if (input == "3")
                //    ListRound();
                if (input == "4")
                    UpdateRound();
            }

        }

        private void UpdateRound()
        {
            Console.Clear();
            int.TryParse(WriteAndInput("Skriv in år (ex 2000): "), out int date);
            int.TryParse(WriteAndInput("Skriv in månad (ex 05): "), out int date2);
            int.TryParse(WriteAndInput("Skriv in dag (ex 18): "), out int date3);
            FindAndUpdateRound(new DateTime(date, date2, date3));

        }

        //private void ListRound()
        //{
        //    Console.Clear();
        //    ShowAll();
        //}

        private void DeleteRound()
        {
            Console.Clear();
            int.TryParse(WriteAndInput("Skriv in år (ex 2000): "), out int date);
            int.TryParse(WriteAndInput("Skriv in månad (ex 05): "), out int date2);
            int.TryParse(WriteAndInput("Skriv in dag (ex 18): "), out int date3);
            FindAndDeleteRound(new DateTime(date, date2, date3));

        }

        private void CreateRound()
        {
            Console.Clear();
            string weather = WriteAndInput("Skriv in väder: ");
            string course = WriteAndInput("Skriv in bana: ");
            int.TryParse(WriteAndInput("Skriv in poäng: "), out int score);
            int.TryParse(WriteAndInput("Skriv in år (ex 2000): "), out int date);
            int.TryParse(WriteAndInput("Skriv in månad (ex 05): "), out int date2);
            int.TryParse(WriteAndInput("Skriv in dag (ex 18): "), out int date3);

            FindOrCreateRound(new DateTime(date, date2, date3), score, weather, course);
        }
    }
}
