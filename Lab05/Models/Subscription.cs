
namespace Lab05.Models
{


    public class Subscription
    {
        public int CustomerId { get; set; }

        public string ServiceId { get; set; } = string.Empty;
        
        public Customer? Customer { get; set; }
        public FoodDeliveryService? FoodDeliveryService { get; set; }
    }
}