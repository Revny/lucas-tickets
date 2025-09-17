namespace lucas_tickets.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } =string.Empty;
        public string Filename { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
    }
}
