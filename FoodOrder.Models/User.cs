using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class User
    {
        [Required]
        [Key]

        public Guid Id { get; set; }
        [Required]
        public string FISH { get; set; }
        [Required]
        public string Nomer { get; set; }
        [Required]
        public string Manzil { get; set; }
        [Required]
        public List<Mahsulot> Savatcha { get; set; }
    }
}
