using System;
using System.Collections.Generic;
using System.Text;

namespace oop4Assign
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal deliveryFee, decimal weight)
        : base(trackingCode, description, deliveryFee, weight)
        {
        }

        #region part02 Q 4 override Print Shipment
        public override string PrintShipment()
        {
            Console.WriteLine("---Standard Shipment---");
            return base.PrintShipment();
        }
        #endregion
    }
}
