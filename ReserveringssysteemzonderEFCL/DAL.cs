using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ReserveringssysteemzonderEF
{
    public class DAL
    {
        //AANPASSEN
        private readonly string _connectionString =
            "Server=s250.webhostingserver.nl;Port=3306;Database=deb2003784_lemarconnesgite;Uid=deb2003784_lemarconnesgite;Pwd=neJZLmDAkr5yc4rqhkqZ;";

        /*
        // Reservations
        // GET ALL
        public List<Band> GetAllBands()
        {
            var bands = new List<Band>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT Id, Name, Genre FROM Bands";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bands.Add(new Band
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre")
                        });
                    }
                }
            }

            return bands;
        }

        // ADD
        public void AddBand(Band band)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Bands (Name, Genre) VALUES (@Name, @Genre)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", band.Name);
                    cmd.Parameters.AddWithValue("@Genre", band.Genre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // GET BY ID
        public Band? GetBandById(int id)
        {
            Band? band = null;

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT Id, Name, Genre FROM Bands WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            band = new Band
                            {
                                Id = reader.GetInt32("Id"),
                                Name = reader.GetString("Name"),
                                Genre = reader.GetString("Genre")
                            };
                        }
                    }
                }
            }

            return band;
        }

        // UPDATE
        public void UpdateBand(Band band)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE Bands SET Name = @Name, Genre = @Genre WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", band.Name);
                    cmd.Parameters.AddWithValue("@Genre", band.Genre);
                    cmd.Parameters.AddWithValue("@Id", band.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE
        public void DeleteBand(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Bands WHERE Id = @Id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        */



        //====================================================


        // Guests

        //GetAllGuests
        public List<Guest> GetAllGuests()
        {
            var guests = new List<Guest>();
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT GastID, Naam, Email, Tel, Straat, Huisnr, Postcode, Plaats, Land, IBAN FROM GAST";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        guests.Add(new Guest
                        {
                            GuestID = reader.GetInt32(0),
                            GuestName = reader.GetString(1),
                            GuestEmail = reader.GetString(2),
                            GuestTelNr = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Street = reader.GetString(4),
                            HouseNr = reader.GetString(5),
                            PostalCode = reader.GetString(6),
                            City = reader.GetString(7),
                            Country = reader.IsDBNull(8) ? null : reader.GetString(8),
                            IBAN = reader.IsDBNull(9) ? null : reader.GetString(9)
                        });
                    }
                }
            }
            return guests;
        }

        

        // ADD
        public void AddGuest(Guest guest)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO GAST (Naam, Email, Tel, Straat, Huisnr, Postcode, Plaats, Land, IBAN) 
                            VALUES (@Naam, @Email, @Tel, @Straat, @Huisnr, @Postcode, @Plaats, @Land, @IBAN)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Naam", guest.GuestName);
                    cmd.Parameters.AddWithValue("@Email", guest.GuestEmail);
                    cmd.Parameters.AddWithValue("@Tel", guest.GuestTelNr);
                    cmd.Parameters.AddWithValue("@Straat", guest.Street);
                    cmd.Parameters.AddWithValue("@Huisnr", guest.HouseNr);
                    cmd.Parameters.AddWithValue("@Postcode", guest.PostalCode);
                    cmd.Parameters.AddWithValue("@Plaats", guest.City);
                    cmd.Parameters.AddWithValue("@Land", guest.Country);
                    cmd.Parameters.AddWithValue("@IBAN", guest.IBAN);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // GET BY ID
        public Guest? GetGuestById(int id)
        {
            Guest? guest = null;

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT Naam, Email, Tel, Straat, Huisnr, Postcode, Plaats, Land, IBAN FROM GAST WHERE GastID = @Id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            guest = new Guest
                            {
                                GuestName = reader.GetString(0),
                                GuestEmail = reader.GetString(1),
                                GuestTelNr = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Street = reader.GetString(3),
                                HouseNr = reader.GetString(4),
                                PostalCode = reader.GetString(5),
                                City = reader.GetString(6),
                                Country = reader.IsDBNull(7) ? null : reader.GetString(7),
                                IBAN = reader.IsDBNull(8) ? null : reader.GetString(8)
                            };
                        }
                    }
                }
            }

            return guest;
        }

        // UPDATE
        public void UpdateGuest(Guest guest)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"UPDATE GAST 
                            SET Naam=@Naam, Email=@Email, Tel=@Tel, Straat=@Straat, Huisnr=@Huisnr, 
                                Postcode=@Postcode, Plaats=@Plaats, Land=@Land, IBAN=@IBAN
                            WHERE GastID=@Id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", guest.GuestID);
                    cmd.Parameters.AddWithValue("@Naam", guest.GuestName);
                    cmd.Parameters.AddWithValue("@Email", guest.GuestEmail);
                    cmd.Parameters.AddWithValue("@Tel", guest.GuestTelNr);
                    cmd.Parameters.AddWithValue("@Straat", guest.Street);
                    cmd.Parameters.AddWithValue("@Huisnr", guest.HouseNr);
                    cmd.Parameters.AddWithValue("@Postcode", guest.PostalCode);
                    cmd.Parameters.AddWithValue("@Plaats", guest.City);
                    cmd.Parameters.AddWithValue("@Land", guest.Country);
                    cmd.Parameters.AddWithValue("@IBAN", guest.IBAN);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE
        public void DeleteGuest(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM GAST WHERE GastID = @Id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    
    }

}
