namespace eventlist.Models
{
    
    
        public class Events
        {
            public string Title { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public int Category { get; set; }

            public DateTime Createdate { get; set; }
            public string Location { get; set; } = string.Empty;
            public string Owner { get; set; } = string.Empty;
        
        }
    }


