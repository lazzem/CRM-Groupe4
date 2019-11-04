using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenWeb.Models
{
    public class UserModels
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.DateTime)]
        public DateTime Birthdate { get; set; }
        public string login { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
        [DataType(DataType.ImageUrl), Display(Name = "Image")]
        public string Image { get; set; }
        public string Function { get; set; }
    }
}