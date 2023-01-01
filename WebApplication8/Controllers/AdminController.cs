using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminIndex()
        {
            return View();
        }
        
        public IActionResult CreateUser()
        {
            return View();
        }

        
        public  IActionResult ShowUsers()
        {
            //Database call to get the list of available users
            ViewBag.usersList = userData.userList;
            //Console.WriteLine(userData.userList);
            return View();
   
        }

        public IActionResult CreateShipment()
        {
            return View();
        }

        public IActionResult AddShipment(shipment shipmentDetails)
        {
            ShipmentList.shipmentList.Add(shipmentDetails);

            return RedirectToAction("ShowShipment", "Admin");
        }


        /*public IActionResult ShowShipment()
        {
            //Database call to get the list of available shipments
            ViewBag.shipmentList = ShipmentList.shipmentList;
            
            return View();

        }*/

        public IActionResult DeleteShipment()
        {
            return View();
        }


        public IActionResult ShipmentError()
        {

            ViewBag.shipmentList = ShipmentList.shipmentList;
            ViewBag.newerrorMessage = "A shipment with the order number could not be found, please check your input and try again.";
            return View();
        }

        

        public IActionResult FindShipment()
        {
            return View();
        }

        public IActionResult ShowShipment(string error = "")
        {
            //Database call to get the list of available shipments
            ViewBag.shipmentList = ShipmentList.shipmentList;

            if (error != null)
            {
                RedirectToAction("ShipmentError", "Admin");

            }
            else
            {
                return View();
            }

            //Console.WriteLine(userData.userList);
            return View();

        }

        public IActionResult CurrentShipment(shipment input)
        {

            foreach (var eachShipment in ShipmentList.shipmentList)
            {
                if (eachShipment.orderNumber == input.orderNumber)
                {
                    currentShipment.orderNum = eachShipment.orderNumber;

                    return RedirectToAction("currentShipmentPage", "Admin", new { orderNumber = eachShipment.orderNumber });
                    
                }
                
            }
            ViewBag.errorMessage = "Invalid Order Number. Try again...";
            return RedirectToAction("ShipmentError", new { input });

        }

        public IActionResult currentShipmentPage()
        {
            return View();
        }



    }
}
