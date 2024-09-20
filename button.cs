static void ShowMenu()
{
    Console.WriteLine("1. Previous");
    Console.WriteLine("2. Next");
    Console.WriteLine("3. Add New");
    Console.WriteLine("4. Delete");
    Console.WriteLine("5. Save");
    Console.WriteLine("6. Exit");

    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            // Implement previous logic
            break;
        case "2":
            // Implement next logic
            break;
        case "3":
            // Implement add new logic
            break;
        case "4":
            // Implement delete logic
            break;
        case "5":
            // Implement save logic
            break;
        case "6":
            Environment.Exit(0);
            break;
    }
}