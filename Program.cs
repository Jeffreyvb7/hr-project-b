using System;
using System.Collections.Generic;
using System.Linq;

namespace Applicatie
{
    class Program
    {
        public static void Main(string[] args)
        {
            LoggingIn();
        }

        public static void LoggingIn()
        {
            var login = new Login();
            
            Console.Clear();
            login.LoginMenu();
            AnythingToContinue();
            Menu();
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
                    "\t2 - Show Menu\n" +
                    "\t3 - Book a escape room\n" +
                    "\t4 - Information about our company\n" +
                    "\t- - Escape room options (Employees only!)\n" +
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
                        AnythingToContinue();
                        break;
                    case "2":
                        Console.Clear();
                        Menuscherm.FoodDrinkMenu();
                        AnythingToContinue();
                        break;
                    case "3":
                        Console.Clear();
                        EscapeRoomReservation.Menu();;
                        AnythingToContinue();
                        break;
                    case "4":
                        Console.Clear();
                        Information.showinfo();
                        AnythingToContinue();
                        break;
                    case "-":
                        Console.Clear();
                        EscapeRoomMenu();
                        break;
                    case "i":
                        Information.showinfo();
                        string enterskip = Console.ReadLine();
                        break;
                }
            }
        }
        static void EscapeRoomMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.Write(
                    "\n\nEscape room options:\n" +
                    "\t1 - Show list of escape rooms\n" +
                    "\t2 - Add escape room\n" +
                    "\t3 - Edit escape room\n" +
                    "\t4 - Remove escape room\n" +
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
                        AnythingToContinue();
                        break;

                    case "2":
                        Console.Clear();
                        EscapeRoomController.CreateRoom();
                        AnythingToContinue();
                        break;

                    case "3":
                        Console.Clear();
                        EscapeRoomController.EditRoom();
                        AnythingToContinue();
                        break;

                    case "4":
                        Console.Clear();
                        EscapeRoomController.DeleteRoom();
                        AnythingToContinue();
                        break;
                }
            }
        }

        static void AnythingToContinue()
        {
            Console.Write("\nPress anything to continu...");
            Console.ReadLine();
        }
    }
}

