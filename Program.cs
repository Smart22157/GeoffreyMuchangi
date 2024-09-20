class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Login");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        LoginForm loginForm = new LoginForm();
        if (loginForm.Login(username, password))
        {
            Console.WriteLine("Login successful!");
            // Navigate to your main form logic here
        }
        else
        {
            Console.WriteLine("Invalid credentials. Exiting.");
        }
    }
}