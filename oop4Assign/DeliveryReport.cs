using System;
using System.Collections.Generic;
using System.Text;

namespace oop4Assign
{
    #region part02 Q6
    internal class DeliveryReport
    {
        public void Printshipment(ITrackable shipment)
        {
            Console.WriteLine($"Tracking Status : {shipment.GetTrackingStatus}");
        }
        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"Shipment Insurance : {shipment.CalculateInsurance}");
        }
    } 
    #endregion
}
