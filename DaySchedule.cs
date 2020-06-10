using System;
using System.Collections.Generic;

namespace Applicatie{
    //Class voor de dagplanning van één kamer
    class DaySchedule {
        public bool Filled;
        public List<Booking> Schedule;
        public string RoomID;

        public DaySchedule(string roomID) {
            this.Filled = false;
            this.Schedule = new List<Booking>();
            this.RoomID = roomID;
        }

        //Gaat eerst met een for loop het rijtje af om te kijken of er overlap is. Als dat niet is voegt hij hem toe.
        public bool AddBooking(Booking booking){
            for (int i = 0; i < this.Schedule.Count; i++){
                if (Overlap(Schedule[i], booking)){
                    return false;
                }
            }
            this.Schedule.Add(booking);
            return true;
        }

        public void ShowSchedule(){
            Console.Clear();
            Console.WriteLine("Room: " + EscapeRoomReservation.GetNameFromID(this.RoomID) + "\nOn this day, we have " + this.Schedule.Count + " reservations:\n");
            for (int i = 0; i < this.Schedule.Count; i++) {
                Console.WriteLine("[" + i + "]:     " + EscapeRoomReservation.TijdAndersom(Schedule[i].Time) + " - " + EscapeRoomReservation.TijdAndersom(Schedule[i].EndTime));
            }   
                Console.WriteLine("\nPress anthing to continue...");
                Console.ReadLine();
        }

        //Checkt of er overlap is tussen de tijden van de twee boekingen
        public bool Overlap(Booking booking, Booking booking2){
            if (booking.SetupTime >= booking2.SetupTime && booking.SetupTime<= booking2.EndTime) {
                return true;
            }
            else{;
                return false;
            }
        }
    }
}