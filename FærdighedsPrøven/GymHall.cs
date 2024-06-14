using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest
{
    public class GymHall
    {
        private int _id;
        private string _name;
        private string _address;
        private string _phone;
        private string _email;
        private Dictionary<int, Booking> bookings;

        public GymHall()
        {
            _id = Id;
            _name = Name;
            _address = Address;
            _phone = Phone;
            _email = Email;
            bookings = new Dictionary<int, Booking>();
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Dictionary<int, Booking> Bookings
        {
            get { return bookings; }
        }
        public void RegisterBooking(Booking booking)
        {
            bookings.Add(booking.Id, booking);
        }
        public void RemoveBooking(Booking booking)
        {
            foreach(Booking booking1 in bookings.Values)
            {
                if(booking1.Id == booking.Id)
                {
                    bookings.Remove(booking1.Id);
                }
            }
        }
        public void PrintBookings()
        {
            foreach (Booking booking in bookings.Values)
            {
                if(booking != null)
                {
                    Console.WriteLine($"\n{booking}");
                }
                else
                {
                    Console.WriteLine("Der er ingen bookinger...");
                }
            }
        }
        public int TotalBookings()
        {
            return bookings.Count;
        }
        public bool Validate(Booking booking)
        {
            if (!booking.BookingDurationOK())
            {
                Exception ex = new Exception($"Booking {booking.Id} er mere end 2 timer");
                throw ex;
                //Console.WriteLine("Booking er mere end 2 timer");
                //return false;
            }
            else if (booking.End.Hour -booking.Start.Hour <0)
            {
                Exception ex = new Exception($"Booking {booking.Id}. Start-tid kan ikke være før End-tid");
                throw ex;
                //Console.WriteLine("Start-tid kan ikke være før End-tid");
                //return false;
            }
            else if(booking.Participants > 22)
            {
                Exception ex = new Exception($"Booking {booking.Id}. Der kan ikke være mere end 22 deltagerer");
                throw ex;
                //Console.WriteLine("Der er mere end 22 deltagere");
                //return false;
            } else
            {
                Console.WriteLine($"\nBooking {booking.Id} OK");
                return true;
            }
        }
        public TimeSpan TotalTimeBooked(DateTime dateTime,Booking firstBooking, Booking lastBooking)
        {
            TimeSpan total = lastBooking.End - firstBooking.Start;
            Console.WriteLine($"Den {dateTime.Day} / {dateTime.Month} er der total timer {total} booket");
            return total;
        }
        public override string ToString()
        {
            Console.WriteLine($"Der er: {bookings.Count} bookings til {Name}");
            PrintBookings();
            Console.WriteLine();
            return $"Hallen {Id} - {Name}\n{Address}\n{Phone}\n{Email}";
        }
    }
}
