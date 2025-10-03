
using System.ComponentModel.DataAnnotations;

namespace lucas_tickets.Models
{


    public class Shows
    {
        [Display(Name = "Id")]
        [Key]
        public int ShowId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public DateTime Createdate { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        [Display(Name = "Created")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
    }


