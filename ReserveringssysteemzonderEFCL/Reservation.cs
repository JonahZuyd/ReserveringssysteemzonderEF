using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReserveringssysteemzonderEF
{
    public class Reservation
    {
        public Guest? Guest { get; set; }
        public int AmountAdults { get; set; }
        public int AmountChildren0To7 { get; set; }
        public int AmountChildren0To12 { get; set; } //moet dit 7-12 zijn?
        public int AmountDogs { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Cancelation { get; set; }
        public int? ReservationID { get; set; }


        // Constructor toevoegen 
        
        public Reservation()
        {

        }
        
        public Reservation(Guest guest, int amountAdults,
            int amountChildren0To7, int amountChildren0To12, int amountDogs, DateTime startDate, DateTime endDate, bool cancelation, int reservationID)
        {
            Guest = guest;
            AmountAdults = amountAdults;
            AmountChildren0To7 = amountChildren0To7;
            AmountChildren0To12 = amountChildren0To12;
            AmountDogs = amountDogs;
            StartDate = startDate;
            EndDate = endDate;
            Cancelation = cancelation;
            ReservationID = reservationID;
        }

        //Methodes toevoegen
        public int TotalGuests()
        {
            return AmountAdults + AmountChildren0To7 + AmountChildren0To12;
        }

        public bool IsValidReservation()
        {
            return StartDate < EndDate && AmountAdults > 0;
        }

        // TOSTRING METHOD (Is wat je ziet als je een cw van de class doet.)
        public override string? ToString()
        {
            return $"ID: {ReservationID}, " +
                   $"Guest information: {Guest}" +
                   $"Adults: {AmountAdults}, " +
                   $"Kids 0-7: {AmountChildren0To7}, " +
                   $"Kids 0-12: {AmountChildren0To12}, " +
                   $"Dogs: {AmountDogs}, " +
                   $"Start: {StartDate:dd-MM-yyyy}, " +
                   $"End: {EndDate:dd-MM-yyyy}, " +
                   $"Canceled: {Cancelation}";
        }


    }
}
