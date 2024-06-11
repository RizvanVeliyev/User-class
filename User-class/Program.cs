
using User_class;

static void Main(string[] args)
{
    User[] users = new User[3];

    for (int i = 0; i < users.Length; i++)
    {
        Console.WriteLine($"Enter details for user {i + 1}:");

        Console.Write("Fullname: ");
        string fullname = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        users[i] = new User(fullname, email, password);
    }

    int choice;
    do
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Show all students");
        Console.WriteLine("2. Get info by id");
        Console.WriteLine("0. Quit");

        Console.Write("choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ShowAllUsers(users);
                break;
            case 2:
                GetInfoById(users);
                break;
            case 0:
                Console.WriteLine("Exiting program...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    } while (choice != 0);
}

static void ShowAllUsers(User[] users)
{
    Console.WriteLine("\nAll users:");
    foreach (User user in users)
    {
        user.GetInfo();
    }
}

static void GetInfoById(User[] users)
{
    Console.Write("Enter user id: ");
    int id = Convert.ToInt32(Console.ReadLine());

    User user = User.FindUserById(users, id);
    if (user != null)
    {
        user.GetInfo();
    }
    else
    {
        Console.WriteLine("User not found with the provided id.");
    }
}
