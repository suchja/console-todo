using System;
using System.Collections.Generic;

namespace console_todo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>();

            Console.Write("Bitte gib eine Aufgabe ein: ");
            string todoName = Console.ReadLine();

            todos.Add(new Todo(todoName));
        }
    }
}
