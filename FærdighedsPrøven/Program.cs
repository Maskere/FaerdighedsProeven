namespace SkillTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            GymHall gymHall1 = new GymHall() { Id = 1, Name = "Den store hal",Address = "Charlotteskolen", Phone ="40537194", Email ="emailTilPrøven@Zealand.dk"};
            GymHall gymHall2 = new GymHall() { Id=2, Name="Den lille hal", Address = "Charlotteskolen",Phone="40537194",Email="emailTilPrøven@Zealand.dk"};

            Booking booking1 = new Booking(gymHall1) { Id = 1, Start = new DateTime(2024, 6, 16, 8, 0, 0), End = new DateTime(2024, 6, 16, 10, 0, 0), Participants = 22 };
            Booking booking2 = new Booking(gymHall1) { Id = 2, Start = new DateTime(2024, 6, 16, 10, 0, 0), End = new DateTime(2024, 6, 16, 12, 0, 0), Participants = 13 };
            Booking booking3 = new Booking(gymHall1) { Id = 3, Start = new DateTime(2024, 6, 16, 12, 0, 0), End = new DateTime(2024, 6, 16, 14, 0, 0), Participants = 13 };
            Booking booking4 = new Booking(gymHall1) { Id = 4, Start = new DateTime(2024, 6, 16, 14, 0, 0), End = new DateTime(2024, 6, 16, 16, 0, 0), Participants = 17 };
            Booking booking5 = new Booking(gymHall1) { Id = 5, Start = new DateTime(2024, 6, 16, 18, 0, 0), End = new DateTime(2024, 6, 16, 20, 0, 0), Participants = 17 };


            gymHall1.RegisterBooking(booking1);
            gymHall1.RegisterBooking(booking2);
            gymHall1.RegisterBooking(booking3);
            gymHall1.RegisterBooking(booking4);
            gymHall1.RegisterBooking(booking5);

            //User story 1
            Booking booking6 = new Booking(gymHall1) { Id=6,Start = new DateTime(2024,7,21,14,30,0), End = new DateTime(2024, 7, 21, 15, 30, 0) };
            gymHall1.RegisterBooking(booking6);

            //User story 2
            Console.WriteLine(gymHall2);
            Booking booking7 = new Booking(gymHall2) { Id = 7, Start = new DateTime(2024, 6, 15, 10, 0, 0), End = new DateTime(2024, 7, 21, 12, 0, 0) };
            gymHall2.RegisterBooking(booking7);

            try
            {
                foreach (Booking booking in gymHall1.Bookings.Values)
                {
                    gymHall1.Validate(booking);
                }
                foreach (Booking booking in gymHall2.Bookings.Values)
                {
                    gymHall1.Validate(booking);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            gymHall1.TotalTimeBooked(new DateTime(2024, 6, 16), booking1, booking4);

        }
    }
}
