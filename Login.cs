using System;
using System.IO;

namespace Applicatie
{
    class Login 
    {
        public string path = Directory.GetCurrentDirectory();
        
        public void StartLogin() 
        {  
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\users\\"))
            {
                DirectoryInfo usersDir = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\users\\");  
                usersDir.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }         
            var menu = new Login();
            menu.LoginMenu();
        }

        public void LoginMenu()
        {
            string choice = "";

            Console.WriteLine("Please Choose one of the following options to continue...\n");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                LogIn();
            }
            else if (choice == "2")
            {
                Register();
            }
        }

        public void LogIn()
        {
            string enteredUsername, enteredPassword, username, password = string.Empty;
            Console.WriteLine("LOGIN");
            Console.Write("Enter username: ");
            enteredUsername = Console.ReadLine();
            Console.Write("Enter password: ");
            enteredPassword = Console.ReadLine();
            if(!(enteredUsername == "admin" && enteredPassword == "admin"))
            {
                if (!File.Exists(path +"\\Users\\" + enteredUsername + ".txt"))
                {
                    Console.WriteLine("Login failed");
                    Console.WriteLine("Back to login menu");
                    Console.ReadLine();
                    LogIn();   
                }
                using (StreamReader ReadUser = new StreamReader(File.Open(path +"\\users\\" + enteredUsername + ".txt", FileMode.Open))) 
                {
                    username = ReadUser.ReadLine();
                    password = ReadUser.ReadLine();
                    ReadUser.Close();
                }
                if (!(enteredUsername == username && enteredPassword == password)) 
                { 
                    Console.WriteLine("Login failed");
                    Console.WriteLine("Back to login menu");
                    Console.ReadLine();
                    LoginMenu();
                }
            }                
            Console.WriteLine("Login success");         
        } 

        public void Register()
        {
            string authUsername, authPassword, newUsername, newPassword = string.Empty;

            Console.WriteLine("REGISTER");
            Console.WriteLine("Login as authenticated user");
            
            Console.Write("Enter username: ");
            authUsername = Console.ReadLine();
            Console.Write("Enter password: ");
            authPassword = Console.ReadLine();
            if((authUsername == "admin") && (authPassword == "admin")) 
            {
                Console.WriteLine("Authentication succesfull, register new user: ");
            }
            Console.WriteLine("\nRegister new user");
            Console.Write("Enter username: ");
            newUsername = Console.ReadLine();
            if (!File.Exists(path +"\\users\\" + newUsername + ".txt"))
            {
                Console.Write("Enter password: ");
                newPassword = Console.ReadLine();
            
                using (StreamWriter CreateUser = new StreamWriter(File.Create(path +"\\users\\" + newUsername + ".txt")))
                {
                    CreateUser.WriteLine(newUsername);
                    CreateUser.WriteLine(newPassword);
                    CreateUser.Close();
                }
            }
            else{
                Console.WriteLine("username already exists.");
                Console.ReadLine();
                Register();
            }
            Console.WriteLine("done");
            Console.ReadLine();
            LoginMenu();
        }
    }
}