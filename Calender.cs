using System;

namespace Applicatie{
    //class voor 'x' aantal dagen calender op één kamer.
    class Calender {
        public int maxDays = 30;
        public DaySchedule[] calender;
        public string roomID;

        public Calender(string roomID) {
            this.calender = new DaySchedule[this.maxDays];
            this.roomID = roomID;
            for (int i = 0; i < maxDays; i++){
                this.calender[i] = new DaySchedule(roomID);
                }
            }
        }
}