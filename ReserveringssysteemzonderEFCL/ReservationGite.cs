using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveringssysteemzonderEF
{
    public class ReservationGite : Reservation
    {
        public int AmountRooms { get; set; }
        public bool StatusGite { get; set; } // Volgeboekt of niet

        public ReservationGite(Guest guest, int amountAdults,
            int amountChildren0To7, int amountChildren0To12, int amountDogs, DateTime startDate, DateTime endDate, bool cancelation, int reservationID,
            int amountRooms, bool statusGite)
            : base(guest, amountAdults,
                  amountChildren0To7, amountChildren0To12, amountDogs, startDate, endDate, cancelation, reservationID)
        {
            AmountRooms = amountRooms;
            StatusGite = statusGite;
        }

        // Methodes
        public bool IsGiteAvailable()
        {
            return !StatusGite;
        }

        public string GetGiteInfo()
        {
            return $"Gîte Reservation: {AmountRooms} rooms, Status: {(StatusGite ? "Volgeboekt" : "Beschikbaar")}";
        }
    }
}
