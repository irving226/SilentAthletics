using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SilentAthleticsWebApp.Models
{
   // [Table("Accounts")]  //referring to database table
    public class Account: IdentityUser  //Account  POCO singlular
    {
        //add password
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        [MaxLength(20)]
        [MinLength(7)]
        [Required(ErrorMessage="Please enter a password to continue")]
        public string Password { get; set; }
        [EmailAddress]
        [MaxLength(60)]
        [MinLength(10)]
        [Required(ErrorMessage ="A Username and Email are required")]
        public string Email { get; set; }
        public int BirthDate { get; set; }
        public string Neighborhood { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
        public bool isLoggedIn { get; set; }

    }
}
