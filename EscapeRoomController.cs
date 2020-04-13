using System;
using System.Collections.Generic;
using System.Linq;

namespace Applicatie
{
    class EscapeRoomController
    {
        public static void ShowRooms()
        {
            // Maak gebruik van je EscapeRoom class
            // Kun je ook schrijven als AJsonable.GetAll<EscapeRoom>()
            List<EscapeRoom> rooms = AJsonable.GetAll<EscapeRoom>("EscapeRooms");

            // Als je een teller wilt; kun je het beste gebruik maken van for
            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine($"\nRoom {i}: ");
                Console.WriteLine(rooms[i].ToString());
            }
        }

        public static void ShowSpecificRoom(string roomName)
        {
            EscapeRoom room = AJsonable.Get<EscapeRoom>("EscapeRooms", roomName);
            Console.WriteLine(room.ToString());
        }

        public static string AskQuestion(string question, bool required = false, bool isFloat = false, bool isInt = false)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();

                if (!required || answer.Any())
                {
                    try
                    {
                        if (isFloat)
                            float.Parse(answer);
                        else if (isInt)
                            int.Parse(answer);
                    }

                    catch
                    {
                        Console.WriteLine("Enter a number");
                        continue;
                    }

                    return answer;
                }
                else
                {
                    Console.WriteLine("You need to answer the question");
                }
            }
        }

        public static void CreateRoom()
        {
            // Vergeet hier je controles niet op!
            string name = AskQuestion("Enter name: ", required: true);
            string theme = AskQuestion("Enter theme: ", required: true);
            int maxPlayers = int.Parse(AskQuestion("Enter max amount of players: ", isInt: true));
            int maxDuration = int.Parse(AskQuestion("Enter max duration: ", isInt: true));
            int setupTime = int.Parse(AskQuestion("Enter setup time: ", isInt: true));
            float price = float.Parse(AskQuestion("Enter total price: ", isFloat: true));

            EscapeRoom newRoom = new EscapeRoom()
            {
                name = name,
                theme = theme,
                price = price,
                maxPlayers = maxPlayers,
                maxDuration = maxDuration,
                setupTime = setupTime
            };

            newRoom.Save();
            Console.WriteLine(newRoom.ToString());
            Console.WriteLine($"Escaperoom {newRoom.name} succesfully saved!");
        }

        public static void EditRoom()
        {
            ShowRooms();

            Console.WriteLine("Which room do you want to Edit? (enter to cancel)");
            Console.Write("Name: ");
            string roomName = Console.ReadLine();

            if (roomName == "")
            {
                Console.WriteLine("Edit canceled");
            }
            else
            {
                EscapeRoom room = AJsonable.Get<EscapeRoom>("EscapeRooms", roomName);

                string name = AskQuestion($"(current = {room.name}) Enter new name: ");
                string theme = AskQuestion($"(current = {room.theme}) Enter new theme: ");
                int maxPlayers = int.Parse(AskQuestion($"(current = {room.maxPlayers}) Enter new max amount of players: ", isInt: true));
                int maxDuration = int.Parse(AskQuestion($"(current = {room.maxDuration}) Enter new max duration: ", isInt: true));
                int setupTime = int.Parse(AskQuestion($"(current = {room.setupTime}) Enter new setup time: ", isInt: true));
                float price = float.Parse(AskQuestion($"(current = {room.price}) Enter new total price: ", isFloat: true));

                EscapeRoom.Delete<EscapeRoom>("EscapeRooms", roomName);
                EscapeRoom newRoom = new EscapeRoom()
                {
                    name = name,
                    theme = theme,
                    price = price,
                    maxPlayers = maxPlayers,
                    maxDuration = maxDuration,
                    setupTime = setupTime
                };

                newRoom.Save();
                Console.WriteLine(newRoom.ToString());
                Console.WriteLine($"Escaperoom {newRoom.name} succesfully edited!");
            }
        }
        public static void DeleteRoom()
        {
            ShowRooms();

            Console.WriteLine("Which room do you want to delete? (enter to cancel)");
            Console.Write("Name: ");
            string roomName = Console.ReadLine();

            if (roomName == "")
            {
                Console.WriteLine("Deletion canceled");
            }
            else
            {
                if (EscapeRoom.Delete<EscapeRoom>("EscapeRooms", roomName))
                {
                    Console.WriteLine($"Room {roomName} deleted");
                    Console.Write("Press enter to continu...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Room cannot be found");
                    Console.Write("Press enter to continu...");
                    Console.ReadLine();
                }
            }
        }
    }
}

