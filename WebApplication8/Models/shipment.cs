namespace WebApplication8.Models
{
    public class shipment
    {
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
