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
                        string[] topTodos = new string[topTodoCount];
                        for (int i = 0; i < topTodoCount; i++)
                        {
                            topTodos[i] = $"{i+1} - {todos[i].Name}";
                        }
                        ConsoleView.ShowTopTodosToUser(topTodos);
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
