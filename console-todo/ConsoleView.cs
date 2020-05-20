using System;
using System.Collections.Generic;
using System.Text;

namespace console_todo
{
    static class ConsoleView
    {
        public static UserActivities GetNextActivityFromUser()
        {
            UserActivities result = UserActivities.Invalid;
            bool isUserInputValid = false;

            while (!isUserInputValid)
            {
                string userSelection = GetUserInput();
                try
                {
                    result = ExtractUserActivity(userSelection);
                    isUserInputValid = true;
                }
                catch (NotImplementedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return result;
        }

        public static string GetTodoNameFromUser()
        {
            Console.Write("Bitte gib eine Aufgabe ein: ");
            return Console.ReadLine();
        }

        private static string GetUserInput()
        {
            Console.WriteLine("### TODO-APP ###");
            Console.WriteLine("Was möchtest du als nächstes machen?");
            Console.WriteLine("1 - Neues ToDo hinzufügen");
            Console.WriteLine("2 - Top 3 Todos anzeigen");
            Console.Write("Deine Auswahl (1 oder 2): ");

            return Console.ReadLine();
        }

        private static UserActivities ExtractUserActivity(string input)
        {
            UserActivities result;

            switch (input)
            {
                case "1":
                    result = UserActivities.AddTodo;
                    break;
                case "2":
                    result = UserActivities.ListTopTodos;
                    break;
                default:
                    throw new NotImplementedException($"Deine Eingabe ('{input}') wird momentan nicht unterstützt!");
            }

            return result;
        }
    }
}
