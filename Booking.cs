using System;

namespace Applicatie{
    //class voor één boeking
    class Booking {
        public int numPlayers;
        public int time;
        public string roomID;
        public string lastName;
        public string phoneNumber;
        public int EndTime;
        public int SetupTime;
        public int day;

        public Booking(int numPlayers, int time, string roomID, string lastName, string phoneNumber, int day, int endTime, int setupTime) {
            this.numPlayers = numPlayers;
            this.roomID = roomID;
            this.time = time;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.EndTime = endTime;
            this.SetupTime = setupTime;
            this.day = day;
        }
    }



}