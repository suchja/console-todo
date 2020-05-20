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
            UserActivities nextActivity = ConsoleView.GetNextActivityFromUser();

            switch (nextActivity)
            {
                case UserActivities.AddTodo:
                    string todoName = ConsoleView.GetTodoNameFromUser();
                    todos.Add(new Todo(todoName));
                    break;

                case UserActivities.ListTopTodos:
                    break;
                case UserActivities.Invalid:
                    break;
                default:
                    break;
            }
        }
    }
}
