using System.ComponentModel.DataAnnotations;

namespace AdressDataAPI.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int FileID { get; set; }
        
        [Required]
        public string Aktenzeichen { get; set; }

        public string Rechtsform { get; set; }
        public string Anrede { get; set; }
        public string Titel { get; set; }

        [Required]
        public string Vorname { get; set; }

        [Required]
        public string Nachname { get; set; }

        public string Straße { get; set; }
        public string Hausnummer { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Land { get; set; }
        public string Import { get; set; }
        public string Datenquelle { get; set; }
        public bool AktuelleAnschrift { get; set; }

        [Required]
        public string AddressStatus { get; set; }
    }
}
