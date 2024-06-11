

namespace User_class
{
    internal class User
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Fullname { get; }
        public string Email { get; }

        public User(string fullname, string email, string password)
        {
            Id = nextId++;
            Fullname = fullname;
            Email = email;

            if (!PasswordChecker(password))
            {
                Console.WriteLine("Sifre yalnisdi");
                while (!PasswordChecker(password))
                {
                    Console.Write("Sifreni yeniden daxil edin:");
                    password = Console.ReadLine();
                }
            }

            Console.WriteLine("istifadeci yaradildi!");
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                else if (char.IsLower(c))
                    hasLowerCase = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
            }

            return hasUpperCase && hasLowerCase && hasDigit;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
        }

        public static User FindUserById(User[] users, int id)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                    return user;
            }
            return null;
        }
    }
}
