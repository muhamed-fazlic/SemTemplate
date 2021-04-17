using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Proizvod
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Naziv proizvoda je obavezno polje.")]
        [MaxLength(60, ErrorMessage = "Maksimalna dužina za ime je 60 karaktera.")]
        public string Name { get; set; }
  
        public ICollection<Adresa> Employees { get; set; }
    }
}
