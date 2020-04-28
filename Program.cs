using System;
using System.Collections.Generic;
using System.Linq;

namespace Applicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Welcome to Escape, The place to visit for your escape room needs");
            while (true)
            {
                Console.Write(
                    "\n\nChoose an option from the following list:\n" +
                    "\ta - Show current escape rooms\n" +
                    "\ts - Show Menu\n" +
                    "\td - Book a escape room\n" +
                    "\ti - Information about our company\n" +
                    "\t- - Escape room options (Employees only!)\n" +
                    "\t= - Exit\n" +
                    "Your option? "
                );

                // Menu options
                switch (Console.ReadLine())
                {
                    case "=":
                        return;
                    case "a":
                        EscapeRoomController.ShowRooms();
                        break;
                    case "s":
                        Console.WriteLine("Menu");
                        break;
                    case "d":
                        Console.WriteLine("Bookings");
                        break;
                    case "-":
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
                        EscapeRoomController.ShowRooms();
                        break;

                    case "2":
                        EscapeRoomController.CreateRoom();
                        break;

                    case "3":
                        EscapeRoomController.EditRoom();
                        break;

                    case "4":
                        EscapeRoomController.DeleteRoom();
                        break;
                }
            }
        }
    }
}

