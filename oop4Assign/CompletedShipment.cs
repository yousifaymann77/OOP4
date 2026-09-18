using System;
using System.Collections.Generic;
using System.Text;

namespace oop4Assign
{
    internal class CompletedShipment :Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee) : base(trackingCode, description, weight, deliveryFee)
        {
        }
    }
}
