using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab05.Models
{
    public class FoodDeliveryService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "Registration Number")]
        public string Id { get; set; } = string.Empty;

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Fee { get; set; }

        // Navigation property: list of subscriptions associated with this service
        public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();

        // Convenience property to get subscribed customers directly
        [NotMapped]
        public IEnumerable<Customer> SubscribedCustomers => 
            Subscriptions != null ? 
            Subscriptions.Select(s => s.Customer) : 
            Enumerable.Empty<Customer>();
    }
}
