
using User_class;

static void Main(string[] args)
{
    User[] users = new User[3];

    for (int i = 0; i < users.Length; i++)
    {
        Console.WriteLine($"detallari daxil et: {i + 1}:");

        Console.Write("Ad: ");
        string fullname = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Sifre: ");
        string password = Console.ReadLine();

        users[i] = new User(fullname, email, password);
    }

    int choice;
    do
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. hamisini goster");
        Console.WriteLine("2. id ile melumat");
        Console.WriteLine("0. cixis");

        Console.Write("secim: ");
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
                Console.WriteLine("Programdan cixdi...");
                break;
            default:
                Console.WriteLine("yeniden daxil edin.");
                break;
        }
    } while (choice != 0);
}

static void ShowAllUsers(User[] users)
{
    Console.WriteLine("\nButun istifadeciler:");
    foreach (User user in users)
    {
        user.GetInfo();
    }
}

static void GetInfoById(User[] users)
{
    Console.Write("istifadeci id-sin daxil et: ");
    int id = Convert.ToInt32(Console.ReadLine());

    User user = User.FindUserById(users, id);
    if (user != null)
    {
        user.GetInfo();
    }
    else
    {
        Console.WriteLine("tapilmadi.");
    }
}
