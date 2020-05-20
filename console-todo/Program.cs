using System;
using System.Collections.Generic;

namespace console_todo
{
    enum UserActivities
    {
        AddTodo = 0,
        ListTopTodos,
        Exit
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool isExitRequested = false;
            List<Todo> todos = new List<Todo>();
            UserActivities nextActivity;

            while (!isExitRequested)
            {
                nextActivity = ConsoleView.GetNextActivityFromUser();
                switch (nextActivity)
                {
                    case UserActivities.AddTodo:
                        string todoName = ConsoleView.GetTodoNameFromUser();
                        todos.Add(new Todo(todoName));
                        break;

                    case UserActivities.ListTopTodos:
                        break;

                    case UserActivities.Exit:
                        isExitRequested = true;
                        break;

                    default:
                        break;
                }

            }
        }
    }
}
