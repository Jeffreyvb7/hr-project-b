using System;
using System.Collections.Generic;

namespace Applicatie{
    //Class voor de dagplanning van één kamer
    class DaySchedule {
        public bool filled;
        public List<Booking> schedule;
        public string roomID;

        public DaySchedule(string roomID) {
            this.filled = false;
            this.schedule = new List<Booking>();
            this.roomID = roomID;
        }

        //Gaat eerst met een for loop het rijtje af om te kijken of er overlap is. Als dat niet is voegt hij hem toe.
        public bool addBooking(Booking booking){
            for (int i = 0; i < this.schedule.Count; i++){
                if (Overlap(schedule[i], booking)){
                    return false;
                }
            }
            this.schedule.Add(booking);
            return true;
        }

        public void showSchedule(){
            Console.Clear();
            Console.WriteLine("Room: " + EscapeRoomReservation.GetNameFromID(this.roomID) + "\nOn this day, we have " + this.schedule.Count + " reservations:\n");
            for (int i = 0; i < this.schedule.Count; i++) {
                Console.WriteLine("[" + i + "]:     " + EscapeRoomReservation.tijdAndersom(schedule[i].time) + " - " + EscapeRoomReservation.tijdAndersom(schedule[i].endTime));
            }   
                Console.WriteLine("\nPress anthing to continue...");
                Console.ReadLine();
        }

        //Checkt of er overlap is tussen de tijden van de twee boekingen
        public bool Overlap(Booking booking, Booking booking2){
            if (booking.setupTime >= booking2.setupTime && booking.setupTime<= booking2.endTime) {
                return true;
            }
            else{;
                return false;
            }
        }
    }




}