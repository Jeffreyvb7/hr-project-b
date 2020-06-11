using System;
using System.Collections.Generic;
using System.Linq;

namespace Applicatie
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void LoggingIn()
        {
            var login = new Login();
            
            Console.Clear();
            login.LoginMenu();
            PressEnterToContinueInConsole();
            AdminMenu();
        }

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Escap, The place to visit for your escape room needs");
                Console.Write(
                    "\n\nChoose an option from the following list:\n" +
                    "\t1 - Show current escape rooms\n" +
                    "\t2 - Show Food Menu\n" +
                    "\t3 - Book a escape room\n" +
                    "\t4 - Information about our company\n" +
                    "\t- - Admin options (Employees only!)\n" +
                    "\t= - Exit\n" +
                    "Your option? "
                );

                // Menu options
                switch (Console.ReadLine())
                {
                    case "=":
                        return;
                    case "1":
                        Console.Clear();
                        EscapeRoomController.ShowRooms();
                        PressEnterToContinueInConsole();
                        break;
                    case "2":
                        Console.Clear();
                        FoodsMenu.DisplayMenu();
                        PressEnterToContinueInConsole();
                        break;
                    case "3":
                        Console.Clear();
                        EscapeRoomReservation.Menu();;
                        PressEnterToContinueInConsole();
                        break;
                    case "4":
                        Console.Clear();
                        Information.ShowInfo();
                        PressEnterToContinueInConsole();
                        break;
                    case "-":
                        LoggingIn();
                        Console.Clear();
                        break;
                }
            }
        }
        static void AdminMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.Write(
                    "\n\nAdmin options:\n" +
                    "\t1 - Show list of escape rooms\n" +
                    "\t2 - Add escape room\n" +
                    "\t3 - Edit escape room\n" +
                    "\t4 - Remove escape room\n" +
                    "\t5 - Edit information panel\n" +
                    "\t6 - Manage foods and beverages\n" +
                    "\t= - Back\n" +
                    "Your option? "
                );

                switch (Console.ReadLine())
                {
                    case "=":
                        return;
                    case "1":
                        Console.Clear();
                        EscapeRoomController.ShowRooms();
                        PressEnterToContinueInConsole();
                        break;

                    case "2":
                        Console.Clear();
                        EscapeRoomController.CreateRoom();
                        PressEnterToContinueInConsole();
                        break;

                    case "3":
                        Console.Clear();
                        EscapeRoomController.EditRoom();
                        PressEnterToContinueInConsole();
                        break;

                    case "4":
                        Console.Clear();
                        EscapeRoomController.DeleteRoom();
                        PressEnterToContinueInConsole();
                        break;

                    case "5":
                        Console.Clear();
                        Information.EditInfo();
                        break;

                    case "6":
                        Console.Clear();
                        FoodsMenu.MenuForFoodsMenu();
                        break;
                }
            }
        }

        public static void PressEnterToContinueInConsole()
        {
            Console.Write("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}

