
namespace User_class;
internal class Program
{
    public static void Main()
    {
        User[] users = new User[3];

        for (int i = 0; i < users.Length; i++)
        {
            Console.WriteLine($"Enter {i + 1}.user:");
            Console.Write("Fullname: ");
            string fullname = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            string password;
            while (true)
            {
                Console.Write("Password: ");
                password = Console.ReadLine();
                if (User.PasswordChecker(password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("wrong password.");
                }
            }

            users[i] = new User(fullname, email, password);
        }

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Show all students,2. Get info by id,0. Quit:");
            
            string option = Console.ReadLine();

            if (option == "0") break;
            
            else if (option == "1")
            {
                foreach (var user in users)
                {
                    user.GetInfo();
                }
            }
            else if (option == "2")
            {
                Console.Write("Enter user ID: ");
                int id;
                id = int.Parse(Console.ReadLine());
                User.FindUserById(id, users);
            }
            else
            {
                Console.WriteLine("user cant found");
            }
        }
    }

    
}

