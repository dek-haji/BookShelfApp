using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelfApp2.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Last Name")]
        public string PrefferedGenre { get; set; }
        public virtual ICollection<Books> Books { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
        [Display(Name = "Name")]
        public string fullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
