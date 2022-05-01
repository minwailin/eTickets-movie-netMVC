using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer
    { 
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfileURL { get; set; }

        [Display(Name = "Name")]
        public string Fullname { get; set; }

        [Display(Name = "Biography")]
        public string BIO { get; set; }

        //Relations models
        public List<Movie> Movies { get; set; }
    }
}
