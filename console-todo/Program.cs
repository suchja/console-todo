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
                        int topTodoCount = todos.Count;
                        if (topTodoCount > 3)
                        {
                            topTodoCount = 3;
                        }
                        for (int i = 0; i < topTodoCount; i++)
                        {
                            ConsoleView.ShowToUser(todos[i]);
                        }
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
