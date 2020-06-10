using System;

namespace Applicatie{
    //class voor één boeking
    class Booking {
        public int NumPlayers;
        public int Time;
        public string RoomID;
        public string LastName;
        public string PhoneNumber;
        public int EndTime;
        public int SetupTime;
        public int Day;

        public Booking(int numPlayers, int time, string roomID, string lastName, string phoneNumber, int day, int endTime, int setupTime) {
            this.NumPlayers = numPlayers;
            this.RoomID = roomID;
            this.Time = time;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.EndTime = endTime;
            this.SetupTime = setupTime;
            this.Day = day;
        }
    }



}