using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace WebApplication8.Models
{
    public class shipment
    {
        [Required]
        public string orderNumber { get; set; }
        public string customerName { get; set; }
        public int orderQty { get; set; }

        public shipment()
        {
          
        }

        public shipment(string orderNumber, string customerName, int orderQty)
        {
            this.orderNumber = orderNumber;
            this.customerName = customerName;
            this.orderQty = orderQty;
        }
    }

    
}
