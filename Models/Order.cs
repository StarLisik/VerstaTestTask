namespace ASPTest.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? CitySender { get; set; }
        public string? AdressSender { get; set; }    
        public string? CityRecipient {  get; set; }
        public string? AdressRecipient { get; set; }
        public int Weight { get; set; }
        public DateTime Date { get; set; }
    }
}
