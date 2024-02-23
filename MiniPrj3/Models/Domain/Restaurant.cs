namespace MiniPrj3.Models.Domain
{
    public class Restaurant
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }    
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }    
        public string State { get; set; }

    }
}
