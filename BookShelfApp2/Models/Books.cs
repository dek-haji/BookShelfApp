using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelfApp2.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "publish date")]
        public DateTime PublishDate { get; set; }
        public int AuthorId { get; set; }
       
    }
}
