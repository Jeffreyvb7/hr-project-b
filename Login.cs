using System;
using System.IO;

namespace Applicatie
{
    class Login {
        public string path = Directory.GetCurrentDirectory();
        
        public void Mayn() {  
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\users\\")){
            DirectoryInfo di = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\users\\");  
            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }         
            var menu = new Login();
            menu.LoginMenu();
        }

        void LoginMenu(){
            string choice = "";

            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");
            choice = Console.ReadLine();
            if (choice == "1"){
                LogIn();
            }
            else if (choice == "2"){
                Register();
            }
        }

        void LogIn(){
            string enteredUsername, enteredPassword, username, password = string.Empty;
            Console.WriteLine("LOGIN");
            Console.Write("Enter username: ");
            enteredUsername = Console.ReadLine();
            Console.Write("Enter password: ");
            enteredPassword = Console.ReadLine();
            if (!File.Exists(path +"\\users\\" + enteredUsername + ".txt")){
                Console.WriteLine("Login failed");
                Console.ReadLine();
                LogIn();   
            }
            else{
                using (StreamReader sr = new StreamReader(File.Open(path +"\\users\\" + enteredUsername + ".txt", FileMode.Open))) {
                    username = sr.ReadLine();
                    password = sr.ReadLine();
                    sr.Close();
                }
                if (enteredUsername == username && enteredPassword == password) { 
                    Console.WriteLine("Login success");
                    Console.ReadLine();
                    LoggingIn();
            }
            }

         
        } 

        void Register(){
            string newUsername, newPassword = string.Empty;

            Console.WriteLine("REGISTER");

            Console.Write("Enter username: ");
            newUsername = Console.ReadLine();
            if (!File.Exists(path +"\\users\\" + newUsername + ".txt")){
                Console.Write("Enter password: ");
                newPassword = Console.ReadLine();
            
                using (StreamWriter sw = new StreamWriter(File.Create(path +"\\users\\" + newUsername + ".txt"))){
                    sw.WriteLine(newUsername);
                    sw.WriteLine(newPassword);
                    sw.Close();
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

        void LoggingIn(){
            
        }
    }
}