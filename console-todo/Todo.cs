using System;
using System.Collections.Generic;
using System.Text;

namespace console_todo
{
    class Todo
    {
        public string Name { get; private set; }

        public Todo(string name)
        {
            this.Name = name;
        }
    }
}
