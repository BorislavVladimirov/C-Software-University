using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ");

            bool isUsernameValid = false;

            foreach (var user in users)
            {
                if (user.Length >= 3 && user.Length <= 16)
                {
                    foreach (var character in user)
                    {
                        isUsernameValid = false;

                        if (char.IsLetterOrDigit(character) || character == '-' || character == '_')
                        {
                            isUsernameValid = true;
                        }
                        if (!isUsernameValid)
                        {
                            break;
                        }
                    }
                    if (isUsernameValid)
                    {
                        Console.WriteLine(user);
                    }
                }
            }
        }
    }
}
