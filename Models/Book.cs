using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ksiegarniaAplikacja.Models {
    public class Book {
        public int Id { get; set; }

        [DisplayName("Tytuł")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Title { get; set; }

        [DisplayName("Autor")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        public string ISBN { get; set; }

        [DisplayName("Gatunek")]
        public string? Genre { get; set; }

        [DisplayName("Cena")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        [Range(0.01,double.MaxValue, ErrorMessage = "Niepoprawna cena")]
        public double Price { get; set; }
    }
}
