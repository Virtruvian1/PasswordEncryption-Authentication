using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace PasswordEncryptionAuthentication
{
    class TakePassword
    {
        Dictionary<string, string> PasswordStorage = new Dictionary<string, string>();
        Dictionary<string, string> PlainTextPasswordStorage = new Dictionary<string, string>();
        string Username;
        string Password;
        public void AskForPair()
        {
            try
            {
                Console.Write("\r\n" +
                    "       Please enter a username: ");
                Username = Console.ReadLine();
                string HashedUsername = ConvertToHash(Username);
                if (PasswordStorage.ContainsKey($"{HashedUsername}"))
                {
                    throw new ArgumentException();
                }
                Console.Write("       Please enter a password: ");
                Password = Console.ReadLine();
                string HashedPassword = ConvertToHash(Password);
                PasswordStorage.Add(HashedUsername, HashedPassword);
                PlainTextPasswordStorage.Add(Username, Password);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\r\n       {Username} => ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{HashedUsername}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"       {Password} => ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{HashedPassword}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\n       Credentials Added!");
                Thread.Sleep(2000);
                Console.ResetColor();
            }
            catch (ArgumentException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\r\n" +
                    $"       {Username} already exist");
                Thread.Sleep(2000);
                Console.ResetColor();
            }

        }
        public void AuthenticatePair()
        {
            Console.Write("\r\n" +
                    "       Please enter a username: ");
            Username = Console.ReadLine();
            string HashedUsername = ConvertToHash(Username);
            Console.Write("       Please enter a password: ");
            Password = Console.ReadLine();
            string HashedPassword = ConvertToHash(Password);
            if (PasswordStorage.ContainsKey($"{HashedUsername}") && PasswordStorage.ContainsValue($"{HashedPassword}"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\r\n" +
                    "       Credentials Authenticated!");
                Thread.Sleep(1000);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\n" +
                    "       Pair does not exist!");
                Thread.Sleep(2000);
                Console.ResetColor();
            }
        }
        public string ConvertToHash(string source)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, source);
                return hash;
            }
            static string GetMd5Hash(MD5 md5Hash, string input)
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
        public void OnExit()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\r\n       Hashed Pairs: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PasswordStorage.Select(i => $"" +
            $"       {i.Key} <> {i.Value}").ToList().ForEach(Console.WriteLine);
            Console.ForegroundColor = ConsoleColor.Cyan;   
            Console.WriteLine("\r\n       Plain Text Pairs: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PlainTextPasswordStorage.Select(i => $"" +
            $"       {i.Key} <> {i.Value}").ToList().ForEach(Console.WriteLine);
            Console.ResetColor();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TakePassword tp = new TakePassword();
            bool ContinueApplication = true;
            do
            {
                string filler = string.Concat(Enumerable.Repeat('*', 60));
                Console.WriteLine(filler);
                Console.Write("\r\n" +
                    "       PASSWORD AUTHENTICATION SYSTEM\r\n " +
                    "\r\n" +
                    "       Please select one option:\r\n" +
                    "       1. Establish an account\r\n" +
                    "       2. Authenticate a user\r\n" +
                    "       3. Exit the system\r\n" +
                    "\r\n");
                int x = Console.CursorTop;
                int y = Console.CursorLeft;
                Console.SetCursorPosition(0, 25);
                Console.WriteLine(filler);
                Console.SetCursorPosition(y, x);
                Console.Write("       Enter selection: "); 
                try
                {
                    int input = Int16.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            tp.AskForPair();
                            break;
                        case 2:
                            tp.AuthenticatePair();
                            break;
                        case 3:
                            tp.OnExit();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\r\n" +
                                "       Credentials are discarded on exit!");
                            Thread.Sleep(6000);
                            ContinueApplication = false;
                            break;
                        default:
                            throw new Exception();
                    }

                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\n" +
                        "       Invalid Input");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                }
                Console.Clear();
            }
            while (ContinueApplication);       
        }
    }
}
