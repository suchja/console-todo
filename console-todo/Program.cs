using System;
using System.Collections.Generic;

namespace console_todo
{
    enum UserActivities
    {
        AddTodo = 0,
        ListTopTodos,
        Invalid
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>();
            UserActivities nextActivity = GetNextActivityFromUser();

            switch (nextActivity)
            {
                case UserActivities.AddTodo:
                    AddNewTodo(todos);
                    break;
                case UserActivities.ListTopTodos:
                    break;
                case UserActivities.Invalid:
                    break;
                default:
                    break;
            }
        }

        private static void AddNewTodo(List<Todo> todos)
        {
            Console.Write("Bitte gib eine Aufgabe ein: ");
            string todoName = Console.ReadLine();

            todos.Add(new Todo(todoName));
        }

        static UserActivities GetNextActivityFromUser()
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

        private static string GetUserInput()
        {
            Console.WriteLine("### TODO-APP ###");
            Console.WriteLine("Was möchtest du als nächstes machen?");
            Console.WriteLine("1 - Neues ToDo hinzufügen");
            Console.WriteLine("2 - Top 3 Todos anzeigen");
            Console.Write("Deine Auswahl (1 oder 2): ");

            return Console.ReadLine();
        }

        static UserActivities ExtractUserActivity(string input)
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
