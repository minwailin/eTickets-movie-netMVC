using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage = "Profile Picture Is Required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Name")]
        [Required (ErrorMessage ="Full Name Is Required")]
        [StringLength(50 ,MinimumLength =3,ErrorMessage ="Fullname must be 3 or more Characters")]
        public string FullName { get; set; }

        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Biography Input Is Required")]
        public string Bio { get; set; }

 /*       [NotMapped]
        [Display(Name = "Upload Image")]
        public IFormFile ImageFile { get; set; }*/

        //Relations models
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
