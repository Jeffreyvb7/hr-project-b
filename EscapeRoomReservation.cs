using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.IO;

namespace Applicatie{

    //Menu
    class EscapeRoomReservation {
        public static void Menu(){
            List<Calender> listOfCalenders = new List<Calender>();
            //Kijkt of het bestand 'calender' bestaat, als dat niet zo is maakt hij deze aan
            if (!File.Exists(AJsonable.GetPath("Calender", "Calender"))) {
                for (int i = 0; i < AJsonable.GetAll<EscapeRoom>("EscapeRooms").Count; i++) {
                var rooms = AJsonable.GetAll<EscapeRoom>("EscapeRooms");
                var cal = new Calender(rooms[i].ID);
                listOfCalenders.Add(cal);
                }
                JsonManager.SaveData<List<Calender>>(listOfCalenders, "Calender", "Calender");
            } else {
                listOfCalenders = JsonManager.GetData<List<Calender>>("Calender", "Calender");
            }

            Console.WriteLine("1. Book room\n2. Check bookings");
            string option = Console.ReadLine();
            if (option == "1"){
                BookRoom(listOfCalenders);
            }  else if (option == "2") {
                CheckBookings(listOfCalenders);
            }
        }

        public static string GetNameFromID(string idArg) {
            var rooms = AJsonable.GetAll<EscapeRoom>("EscapeRooms");
            for (int i = 0; i < rooms.Count; i++) {
                if (rooms[i].ID == idArg) {
                    return rooms[i].Name;
                    }
                }
            return null;
            }


        public static void CheckBookings(List<Calender> list) {
            int dag = MenuOptions("How many days from now are we checking?", 31, 0);
            for (int roomIndex = 0; roomIndex < list.Count; roomIndex ++) {
                Console.WriteLine(".");
                Console.WriteLine("Room " + GetNameFromID(list[roomIndex].RoomID) + "\n\n");
                list[roomIndex].DayCalender[dag].ShowSchedule();
            }
        }

        public static void BookRoom(List<Calender> chosenList){
            int roomIndex = 0;
            var list = chosenList;
            while (true) {
                var room = RoomPicker();
                for (int i = 0; i < list.Count; i++) {
                        if (list[i].RoomID == room.ID) {
                            roomIndex = i;
                        }
                    }
                Console.Clear();
                int numPlayers = NumberOfPlayers(room.MaxPlayers);
                Console.Clear();
                int dag = MenuOptions("How many days from now will you book?", 31, 0);
                list[roomIndex].DayCalender[dag].ShowSchedule();
                int hoeLaat = Tijd();
                int endTime = room.MaxDuration + hoeLaat;
                int setupTime = hoeLaat - room.SetupTime;
                Console.Clear();
                Console.WriteLine("What's your last name?");
                string lastName = Console.ReadLine();  
                Console.Clear();              
                Console.WriteLine("What's your telephone number?");
                string telephone = Console.ReadLine(); 
                Console.Clear();
                Console.WriteLine("Is the following info correct?\n\n" +
                "Name: " + lastName + "\nTelephone: " + telephone +
                "\nTime: " + TijdAndersom(hoeLaat) +
                "\nRoom: " + room.Name +
                "\nDays from now: " + dag +
                "\nHow many people: " + numPlayers);

                if (MenuOptions("1. Yes\n2. No", 2) == 1) {
                    var boeking = new Booking(numPlayers, hoeLaat, room.ID, lastName, telephone, dag, endTime, setupTime);
                    if (list[roomIndex].DayCalender[dag].AddBooking(boeking) == true) {
                        JsonManager.SaveData<List<Calender>>(list, "Calender", "Calender");
                        Console.Clear();
                        Console.WriteLine("Booking Placed!\n");
                        return;
                    } else {
                        Console.Clear();
                        Console.WriteLine("There appears to be overlap. Please try again");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                } else{
                    Console.Clear();
                    Console.WriteLine("Please enter the info again.");
                    Thread.Sleep(2000);
                }
        }
    }

        //Functie die alle escaperooms uitprint, en vervolgens jouw de keus geeft om er een te kiezen
        public static EscapeRoom RoomPicker(){
            var rooms = AJsonable.GetAll<EscapeRoom>("EscapeRooms");
            while (true){
                EscapeRoomController.ShowRooms();
                int pickedRoomNumber = MenuOptions("Pick the number of the room you want to choose\n", rooms.Count-1);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("You picked the following room:\n");
                Console.WriteLine(rooms[pickedRoomNumber]);
                Console.WriteLine("\n");
                Thread.Sleep(1000);
                Console.WriteLine("Is your choice correct?");
                if (MenuOptions("\n\n1. Yes\n2.No", 2) == 1) {
                    return rooms[pickedRoomNumber];
                }
        }
    }

        //Pakt een string als instructie. Returnt het menu item.
        public static int MenuOptions(string text, int range, int minRange = 0) {
            string answer;
            int pickedOption;
            while (true) {
                Console.WriteLine(text);
                answer = Console.ReadLine();
                try
                {
                    pickedOption = int.Parse(answer);
                }
                catch {
                    Console.WriteLine("\nInvalid input, try again\n");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
                if (pickedOption > range || pickedOption < minRange) {
                    Console.WriteLine("\nInvalid option. Try again\n");
                    Thread.Sleep(1000);
                } else {
                    return pickedOption;
                }
            }
        }
        
        //Pakt de hoeveelheid spelers
        public static int NumberOfPlayers(int maxPlayers){
            int amountOfPlayers;
            amountOfPlayers = MenuOptions("How many players will you bring along?\n", maxPlayers+1);
            return amountOfPlayers;           
        }

        //Pakt de tijd van een gebruiker en convert dit tot minuten
        public static int Tijd(){
            int hour;
            int min;
            hour = MenuOptions("Within two steps you will specify the hour and minute on which you'd like to reserve\n\nPlease specify at which hour you want (9:00-17:00)", 16, 9);
            min = MenuOptions("Now please specify at which minute", 59, 0);
            return TijdConverter(hour, min);
        }
        //wordt gebruikt in de tijd functie om een aantal minuten te returnen
        public static int TijdConverter(int h, int m){
            return m + h*60;
            }

        //wordt gebruikt om tijd in minuten aan de gebruiker te presenteren.
        public static string TijdAndersom(int tijd){
            string tijdString = "";
            int uren = tijd / 60;
            int minuten = tijd % 60;
            if (minuten < 10) {
                tijdString = tijdString + uren + ":0" + minuten;
            } else{
                tijdString = tijdString + uren + ":" + minuten;
            }
            return tijdString;
            }
        }
}