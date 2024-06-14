using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest
{
    public class Booking
    {
        private int _id;
        private DateTime _start;
        private DateTime _end;
        private int _participants;

        public Booking(GymHall gymHall)
        {
            _id = Id;
            _start = Start;
            _end = End;
            _participants = Participants;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }
        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }
        public int Participants
        {
            get { return _participants; }
            set { _participants = value; }
        }
        public bool BookingDurationOK()
        {
            if(End.Hour - Start.Hour > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsSundayBooking()
        {
            if(Start.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Bookingen er på en søndag");
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            
            return $"Booking {Id} starter klokken {Start} og slutter klokken {End}. Der er {Participants} deltagere.";
        }
    }
}
