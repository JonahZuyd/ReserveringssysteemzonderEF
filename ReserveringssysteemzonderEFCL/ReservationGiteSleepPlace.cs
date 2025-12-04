using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveringssysteemzonderEF
{
    public class ReservationGiteSleepPlace: ReservationGite
    {
        public int AmountSleepPlaces { get; set; }
        public int Amount2PersonRooms { get; set; }
        public int Amount3PersonRooms { get; set; }

        // Constructor
        public ReservationGiteSleepPlace(Guest guest,
                                         int amountAdults, int amountChildren0To7, int amountChildren0To12, int amountDogs,
                                         DateTime startDate, DateTime endDate,
                                         bool statusGite, int amountRooms,
                                         int amountSleepPlaces, int amount3PersonRooms, int amount2PersonRooms,
                                         bool cancelation = false)
            : base(guest, amountAdults, amountChildren0To7, amountChildren0To12, amountDogs,
                   startDate, endDate, statusGite, amountRooms, amountSleepPlaces, cancelation)
        {
            AmountSleepPlaces = amountSleepPlaces;
            Amount3PersonRooms = amount3PersonRooms;
            Amount2PersonRooms = amount2PersonRooms;
        }

        // Methode om te checken hoeveel slaapplaatsen nog beschikbaar zijn
        public int CheckAvailableSleepPlaces()
        {
            // Bijvoorbeeld: totaal slaapplaatsen minus het totaal aantal gasten
            int usedSleepPlaces = TotalGuests(); // TotalGuests() komt uit Reservation
            int available = AmountSleepPlaces - usedSleepPlaces;
            return available >= 0 ? available : 0;
        }

        // Methode om een overzicht te geven van deze gîte-reservering
        public string GetSleepPlaceInfo()
        {
            return $"Slaapplaatsen: {AmountSleepPlaces}, 3-persoonskamers: {Amount3PersonRooms}, 2-persoonskamers: {Amount2PersonRooms}, Gasten: {TotalGuests()}, Beschikbaar: {CheckAvailableSleepPlaces()}";
        }
    }
}
