using System;
using System.Linq;
using System.IO;


namespace Applicatie
{
    class EscapeRoomController
    {
        public static void ShowRooms()
        {
            // Maak gebruik van je EscapeRoom class
            // Kun je ook schrijven als AJsonable.GetAll<EscapeRoom>()
            var rooms = AJsonable.GetAll<EscapeRoom>("EscapeRooms");

            // Als je een teller wilt; kun je het beste gebruik maken van for
            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine($"\nRoom {i}: ");
                Console.WriteLine(rooms[i].ToString());
            }
        }

        public static void ShowSpecificRoom(string roomName)
        {
            var room = AJsonable.Get<EscapeRoom>("EscapeRooms", roomName);
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
                            Single.Parse(answer);
                        else if (isInt)
                            Int32.Parse(answer);
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
            Console.WriteLine("Creating new room: ");
            string id = Guid.NewGuid().ToString("N"); 
            string name = AskQuestion("Enter name: ", required: true);
            string theme = AskQuestion("Enter theme: ", required: true);
            int maxPlayers = int.Parse(AskQuestion("Enter max amount of players: ", isInt: true));
            int maxDuration = int.Parse(AskQuestion("Enter max duration: ", isInt: true));
            int setupTime = int.Parse(AskQuestion("Enter setup time: ", isInt: true));
            float price = float.Parse(AskQuestion("Enter total price: ", isFloat: true));

            var newRoom = new EscapeRoom()
            {
                ID = id,
                Name = name,
                Theme = theme,
                Price = price,
                MaxPlayers = maxPlayers,
                MaxDuration = maxDuration,
                SetupTime = setupTime
            };

            newRoom.Save();
            Console.WriteLine(newRoom.ToString());
            Console.WriteLine($"Escaperoom {newRoom.Name} succesfully saved!");
        }

        public static void EditRoom()
        {
            Console.WriteLine("Edit rooms: ");

            ShowRooms();
            bool isDone = false;
            while (!isDone)
            {

                Console.WriteLine("Which room do you want to Edit? (enter to cancel)");
                Console.Write("Name: ");
                string roomName = Console.ReadLine();
                string roomNamePath = AJsonable.GetPath("EscapeRooms", roomName);
                bool escapeRoomExists = File.Exists(roomNamePath);

                if (String.IsNullOrEmpty(roomName))
                {
                    Console.WriteLine("Editing canceled");
                    isDone = true;
                }
                else if (!escapeRoomExists)
                {
                    Console.WriteLine($"{roomName} does not exist.");
                }
                else if (escapeRoomExists)
                {
                    var room = AJsonable.Get<EscapeRoom>("EscapeRooms", roomName);
                    
                    string name = AskQuestion($"(current = {room.Name}) Enter new name: ", required: true);
                    string theme = AskQuestion($"(current = {room.Theme}) Enter new theme: ", required: true);
                    int price = Int32.Parse(AskQuestion($"(current = {room.Price}) Enter new price: ", isInt: true));
                    int maxPlayers = Int32.Parse(AskQuestion($"(current = {room.MaxPlayers}) Enter new max amount of players: ", isInt: true));

                    EscapeRoom.Delete<EscapeRoom>("EscapeRooms", roomName);
                    var newRoom = new EscapeRoom()
                    {
                        ID = room.ID,
                        Name = name,
                        Theme = theme,
                        Price = price,
                        MaxPlayers = maxPlayers,
                        MaxDuration = room.MaxDuration,
                        SetupTime = room.SetupTime
                    };

                    newRoom.Save();
                    Console.WriteLine(newRoom.ToString());
                    Console.WriteLine($"Escaperoom {newRoom.Name} succesfully edited!");
                    isDone = true;
                }
            }
        }

        public static void DeleteRoom()
        {
            Console.WriteLine("Deleting room: ");
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

                }
                else
                {
                    Console.WriteLine("Room cannot be found");
                }
            }
        }
    }
}

