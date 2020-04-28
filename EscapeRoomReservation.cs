using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace Applicatie{

    //Menu
    class EscapeRoomReservation {


        public static void Menu(){
            //Work in progress
            var listOfCalenders = new CalenderList();


            var room = RoomPicker();
            Console.WriteLine(room.name);
            int numPlayers = NumberOfPlayers(room.maxPlayers);
            int hoeLaat = tijd();
        }

        //Functie die alle escaperooms uitprint, en vervolgens jouw de keus geeft om er een te kiezen
        public static EscapeRoom RoomPicker(){
            var rooms = AJsonable.GetAll<EscapeRoom>("EscapeRooms");
            while (true){
                EscapeRoomController.ShowRooms();
                int x = MenuOptions("Pick the number of the room you want to choose\n", rooms.Count-1);
                Thread.Sleep(1000);
                Console.WriteLine("You picked the following room:\n");
                Console.WriteLine(rooms[x]);
                Console.WriteLine("\n");
                Thread.Sleep(1000);
                Console.WriteLine("Is your choice correct?");
                if (MenuOptions("\n\n1. Yes\n2.No", 2) == 1) {
                    return rooms[x];
                }
        }
    }



        //Pakt een string als instructie. Returnt het menu item.
        public static int MenuOptions(string text, int range, int minRange = 0) {
            int x;
            while (true) {
                Console.WriteLine(text);
                x = int.Parse(Console.ReadLine());
                if (x > range) {
                    Console.WriteLine("\nInvalid option. Try again\n");
                    Thread.Sleep(1000);
                } else {
                    return x;
                }
            }
        }
        
        //Pakt de hoeveelheid spelers
        public static int NumberOfPlayers(int maxPlayers){
            int x;
            x = MenuOptions("\nHow many players will you bring along?\n", maxPlayers+1);
            return x;           
        }

        //Pakt de tijd van een gebruiker en convert dit tot minuten
        public static int tijd(){
            int x;
            int y;
            x = MenuOptions("Within two steps you will specify the hour and minute on which you'd like to reserve\n\nPlease specify at which hour you want (9:00-17:00)", 16, 9);
            y = MenuOptions("Now please specify at which minute", 59, 0);
            return TijdConverter(x, y);
        }
        //wordt gebruikt in de tijd functie om een aantal minuten te returnen
        public static int TijdConverter(int h, int m){
            return m + h*60;
            }
        }
    

    //class voor één boeking
    class Booking {
        public int numPlayers;
        public int time;
        public EscapeRoom room;
        public string lastName;
        public string phoneNumber;
        public int endTime;
        public int setupTime;

    	public Booking(int numPlayers, int time, EscapeRoom EscapeRoom, string lastName, string phoneNumber) {
    		this.numPlayers = numPlayers;
    		this.room = EscapeRoom;
    		this.time = time;
    		this.lastName = lastName;
    		this.phoneNumber = phoneNumber;
            this.endTime = this.room.maxDuration + this.time;
            this.setupTime = time - EscapeRoom.setupTime;
    	}
    }


    //Class voor de dagplanning van één kamer
    class DaySchedule {
        public bool filled;
        public List<Booking> schedule;
        public EscapeRoom room;

        public DaySchedule(EscapeRoom room) {
            this.filled = false;
            this.schedule = new List<Booking>();
            this.room = room;

        }

        //Gaat eerst met een for loop het rijtje af om te kijken of er overlap is. Als dat niet is voegt hij hem toe.
        public bool addBooking(Booking booking){
            for (int i = 0; i < schedule.Capacity; i++){
                if (Overlap(schedule[i], booking)){
                    return false;
                }
            }
            schedule.Add(booking);
            return true;
        }


        public void getSchedule(){
            string s;

        }

        //Checkt of er overlap is tussen de tijden van de twee boekingen
        public bool Overlap(Booking booking, Booking booking2){
            if (booking.setupTime >= booking2.setupTime && booking2.setupTime <= booking.endTime) {
                return true;
            }
            else{
                return false;
            }
        }
    }

    //class voor 'x' aantal dagen calender op één kamer.
    class Calender {
        public int maxDays = 30;
        public DaySchedule[] calender;
        public string roomName;

        public Calender(string roomName, EscapeRoom room) {
            this.calender = new DaySchedule[this.maxDays];
            this.roomName = roomName;
            for (int i = 0; i < maxDays; i++){
                this.calender[i] = new DaySchedule(room);
                }
            }
        
        public static void BookedFullPrint() {
            public bool full;
            for (int i = 0; i < this.maxDays; i++) {
                if (this.DaySchedule[i].filled == true) {
                    Console.WriteLine("Day #" + ToString(i+1) + " is full");
                } else {
                    Console.WriteLine("Day #" + ToString(i+1) + " is not full");
                }
            }
        }
        }

    class CalenderList {
        public List<Calender> listOfRoomCalenders;
        public CalenderList(){
            for (int i = 0;  i < AJsonable.GetAll<EscapeRoom>("EscapeRooms").Count; i++) {
            listOfRoomCalenders.Add(new Calender(AJsonable.GetAll<EscapeRoom>("EscapeRooms")[i].name, AJsonable.GetAll<EscapeRoom>("EscapeRooms")[i]));
        }
    }
    }
}

