using ToDoList;

class Program
{
    static void Main(string[] args)
    {
        ToDoTask task = new ToDoTask();

        // Implement a menu or commands to interact with the to-do list

        // Example menu loop
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Edit task");
            Console.WriteLine("3. Remove task");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Handle adding a task
                    break;
                case "2":
                    // Handle editing a task
                    break;
                case "3":
                    // Handle removing a task
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
