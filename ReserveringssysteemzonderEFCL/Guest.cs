using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReserveringssysteemzonderEF
{
    public class Guest
    {
        public int GuestID { get; set; }
        public string? GuestName { get; set; }
        public string? GuestEmail { get; set; }
        public string? GuestTelNr { get; set; }
        public string? Street { get; set; }
        public string? HouseNr { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? IBAN { get; set; }


        public Guest()
        {

        }

        public Guest(int guestID, string guestName, string guestEmail, string guestTelNr,
                     string street, string houseNr, string postalCode, string city, string country, string iban)
        {
            GuestID = guestID;
            GuestName = guestName;
            GuestEmail = guestEmail;
            GuestTelNr = guestTelNr;
            Street = street;
            HouseNr = houseNr;
            PostalCode = postalCode;
            City = city;
            Country = country;
            IBAN = iban;
        }

        public override string ToString()
        {
            return $"Name: {GuestName} \nEmail: {GuestEmail} \nTel: {GuestTelNr} \nAddress: {Street} {HouseNr} \n{PostalCode} {City} \nIBAN: {IBAN}";
        }

    }
}
