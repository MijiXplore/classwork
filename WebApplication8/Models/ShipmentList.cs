namespace WebApplication8.Models
{
    public class ShipmentList
    {
        public static List<shipment>? shipmentList = new List<shipment>()
        {
            new shipment("S001", "Fredrick Stone", 10),
            new shipment("S002", "John Paul", 15),
            new shipment("S003", "ben James", 5),
            new shipment("S004", "Miji Shittu", 14),
            new shipment("S005", "Manpreet Cole", 3),
            new shipment("S006", "Imam Dahli", 20)
        };

    }
}
