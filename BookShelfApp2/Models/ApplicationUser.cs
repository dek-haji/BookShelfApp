using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelfApp2.Models
{
    public class ApplicationUser : IdentityUser
    {
      
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "FullName")]
        public string FullName => $"{FirstName} {LastName}";

        public virtual ICollection<Books> BooksCreated { get; set; }
        public virtual ICollection<Author> AuthorsCreated { get; set; }


    }
}
