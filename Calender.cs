using System;

namespace Applicatie{
    //class voor 'x' aantal dagen calender op één kamer.
    class Calender {
        public int MaxDays = 30;
        public DaySchedule[] DayCalender;
        public string RoomID;

        public Calender(string roomID) {
            this.DayCalender = new DaySchedule[this.MaxDays];
            this.RoomID = roomID;
            for (int i = 0; i < MaxDays; i++){
                this.DayCalender[i] = new DaySchedule(roomID);
                }
            }
        }
}