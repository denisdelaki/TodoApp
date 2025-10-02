var todos = new List<(string task, bool done)>();

while (true)
{
    Console.Clear();
    Console.WriteLine("=== TODO APP ===\n");

    if (todos.Count == 0)
    {
        Console.WriteLine("No todos yet!\n");
    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            string status = todos[i].done ? "[✓]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {todos[i].task}");
        }
        Console.WriteLine();
    }

    Console.WriteLine("1. Add todo");
    Console.WriteLine("2. Mark done");
    Console.WriteLine("3. Remove todo");
    Console.WriteLine("4. Exit");
    Console.Write("\nChoice: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Enter todo: ");
        string task = Console.ReadLine();
        todos.Add((task, false));
    }
    else if (choice == "2")
    {
        Console.Write("Enter number: ");
        if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= todos.Count)
        {
            var todo = todos[num - 1];
            todos[num - 1] = (todo.task, !todo.done);
        }
    }
    else if (choice == "3")
    {
        Console.Write("Enter number: ");
        if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= todos.Count)
        {
            todos.RemoveAt(num - 1);
        }
    }
    else if (choice == "4")
    {
        break;
    }
}

Console.WriteLine("Goodbye!");