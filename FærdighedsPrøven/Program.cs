namespace SkillTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Booking booking1 = new Booking() { Id = 1, Start = new DateTime(2024, 6, 16, 14, 0, 0), End = new DateTime(2024, 6, 16, 16, 0, 0), Participants = 22 };
            Booking booking2 = new Booking() { Id = 2, Start = new DateTime(2024, 6, 21, 8, 0, 0), End = new DateTime(2024, 6, 21, 10, 0, 0), Participants = 13 };
            Booking booking3 = new Booking() { Id = 3, Start = new DateTime(2024, 6, 25, 10, 0, 0), End = new DateTime(2024, 6, 25, 12, 0, 0), Participants = 13 };
            Booking booking4 = new Booking() { Id = 4, Start = new DateTime(2024, 6, 25, 10, 0, 0), End = new DateTime(2024, 6, 25, 12, 0, 0), Participants = 17 };

            GymHall gymHall1 = new GymHall() { Id = 1, Name = "Den store hal",Address = "Charlotteskolen", Phone ="40537194", Email ="emailTilPrøven@Zealand.dk"};
            GymHall gymHall2 = new GymHall() { Id=2, Name="Den lille hal", Address = "Charlotteskolen",Phone="40537194",Email="emailTilPrøven@Zealand.dk"};

            gymHall1.RegisterBooking(booking1);
            gymHall1.RegisterBooking(booking2);
            gymHall1.RegisterBooking(booking3);
            gymHall1.RegisterBooking(booking4);

            //User story 1
            Booking booking5 = new Booking() { Id=5,Start = new DateTime(2024,7,21,14,30,0), End = new DateTime(2024, 7, 21, 15, 30, 0) };
            gymHall1.RegisterBooking(booking5);

            //User story 2
            Console.WriteLine(gymHall2);
            Booking booking6 = new Booking() { Id = 6, Start = new DateTime(2024, 6, 15, 10, 0, 0), End = new DateTime(2024, 7, 21, 12, 0, 0) };
            gymHall2.RegisterBooking(booking6);

            try
            {
                foreach (Booking booking in gymHall1.bookings.Values)
                {
                    gymHall1.Validate(booking);
                }
                foreach (Booking booking in gymHall2.bookings.Values)
                {
                    gymHall1.Validate(booking);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            Console.WriteLine();
            gymHall1.TotalTimeBooked();
        }
    }
}
