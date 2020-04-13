using System;
using System.Collections.Generic;
using System.Reflection;

namespace Applicatie{

    //Menu
    class EscapeRoomReservation {

        public static void Menu(){
            List<EscapeRoom> rooms = AJsonable.GetAll<EscapeRoom>("EscapeRooms");
            while (true){
                EscapeRoomController.ShowRooms();
                //Nog niet af
            }
        }

//        public EscapeRoom RoomPicker(){
//            Console.WriteLine("Enter the name of the room you'd like to pick");
//            Console.ReadLine();
//        }

        
        //Pakt de hoeveelheid spelers
        public int NumberOfPlayers(){
            int x;
            Console.WriteLine("How many people will you bring along?");
            x = int.Parse(Console.ReadLine());
            return x;
        }

        //Pakt de tijd van een gebruiker en convert dit tot minuten
        public int tijd(){
            int x;
            int y;
            Console.WriteLine("Within two steps you will specify the hour and minute on which you'd like to reserve\n\nPlease specify at which hour you want (9:00-17:00)");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please specify at which minute");
            y = int.Parse(Console.ReadLine());
            return TijdConverter(x, y);
        }

        public int TijdConverter(int h, int m){
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


        }
    }


