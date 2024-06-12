

namespace User_class;
using System;

public class User
{
    private static int idCount = 0;
    private int id;
    public int Id
    {
        get { return id; }
    }
    public string Fullname { get; set; }
    public string Email { get; private set; }
    private string password;

    public User(string fullname, string email, string password)
    {
        id = ++idCount;
        Fullname = fullname;
        Email = email;
        if (PasswordChecker(password))
        {
            this.password = password;
        }
        else
        {
            Console.WriteLine("wrong password!");
        }
    }

    public static bool PasswordChecker(string password)
    {
        if (password.Length < 8)
            return false;

        bool hasUpper = false, hasLower = false, hasDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c))
                hasUpper = true;
            if (char.IsLower(c))
                hasLower = true;
            if (char.IsDigit(c))
                hasDigit = true;
        }

        return hasUpper && hasLower && hasDigit;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
    }

    public static User FindUserById(int id, User[] users)
    {
        foreach (var user in users)
        {
            if (user != null && user.Id == id)
            {
                Console.WriteLine($"Id: {user.Id}, Fullname: {user.Fullname}, Email: {user.Email}");
                return user;
            }
        }
        Console.WriteLine("cant found user");
        return null;
    }
}




