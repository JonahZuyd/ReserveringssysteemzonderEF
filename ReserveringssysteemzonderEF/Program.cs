namespace ReserveringssysteemzonderEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //interface
            Guest guest = new Guest();
            Reservation reservation = new Reservation();
            
            Console.WriteLine("Welcome to the Reservation System\n\n");

            
            Console.WriteLine("Wat is uw naam?");
            guest.GuestName = Console.ReadLine();

            Console.WriteLine("Wat is uw e-mailadres?");
            guest.GuestEmail = Console.ReadLine();

            Console.WriteLine("Wat is uw telefoonnummer?");
            guest.GuestTelNr = (Console.ReadLine());

            Console.WriteLine("Wat is uw straatnaam?");
            guest.Street = Console.ReadLine();

            Console.WriteLine("Wat is uw huisnummer?");
            guest.HouseNr = (Console.ReadLine());

            Console.WriteLine("Wat is uw postcode?");
            guest.PostalCode = Console.ReadLine();

            Console.WriteLine("Wat is uw woonplaats?");
            guest.City = Console.ReadLine();

            Console.WriteLine("Gevestigd in welk land?");
            guest.Country = Console.ReadLine();

            Console.WriteLine("Wat is uw IBAN?");
            guest.IBAN = (Console.ReadLine());



            Console.WriteLine("Hoeveel volwassenen?");
            reservation.AmountAdults = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel kinderen van 0 t/m 7 jaar?");
            reservation.AmountChildren0To7 = int.Parse(Console.ReadLine());

            //Dit moet 7-12 zijn, maar staat nu zo i.v.m. conflicten met de database
            Console.WriteLine("Hoeveel kinderen van 0 t/m 12 jaar?");
            reservation.AmountChildren0To12 = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel honden?");
            reservation.AmountDogs = int.Parse(Console.ReadLine());

            Console.WriteLine("Wat is de startdatum? (yyyy-mm-dd)");
            reservation.StartDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Wat is de einddatum? (yyyy-mm-dd)");
            reservation.EndDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Is de reservering geannuleerd? (true/false)");
            reservation.Cancelation = bool.Parse(Console.ReadLine());

            Console.WriteLine("Wat is het reserveringsnummer?");
            reservation.ReservationID = int.Parse(Console.ReadLine());

            // Laat zien wat er is ingevuld
            Console.WriteLine("\n---- Reservering ----");
            Console.WriteLine(reservation.ToString());



            DAL dAL = new DAL();
            dAL.AddGuest(guest);


        }
    }
}
