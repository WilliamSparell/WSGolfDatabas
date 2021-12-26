using static WSGolfDatabas.utiles.OutputHelper;
using static WSGolfDatabas.utiles.CRUDHelper;


namespace WSGolfDatabas.Menu
{
    internal class MainMenu
    {
        public void StartMenu()
        {
            while (true)
            {
                Write("1. Ny Runda");
                Write("2. Radera Person");
                Write("3. Lista Personer");
                Write("4. Uppdatera Person");
                Write("5. Skapa förälder");
                string input = Console.ReadLine();

                if (input == "1")
                    CreateRound();
                if (input == "2")
                    DeleteRound();
                if (input == "3")
                    ListPerson();
                if (input == "4")
                    UpdatePerson();
                if (input == "5")
                    CreateParent();
            }

        }

        private void DeleteRound()
        {
            ShowAll();
        }

        private void CreateRound()
        {
            string weather = WriteAndInput("Skriv in väder");
            string course = WriteAndInput("Skriv in bana");
            int.TryParse(WriteAndInput("Skriv in poäng: "), out int score);

            FindOrCreateRound(DateTime.Now, score, weather, course);
        }
    }
}
