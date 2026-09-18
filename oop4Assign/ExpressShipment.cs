using System;
using System.Collections.Generic;
using System.Text;

namespace oop4Assign
{
    internal class ExpressShipment : Shipment
    {
        public ExpressShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, decimal extraFee)
          : base(trackingCode, description, deliveryFee, weight)
        {
            this.extraFee = extraFee;
        }

        private decimal extraFee;
        public decimal ExtraFee
        {

            get
            {
                return extraFee;
            }
            set
            {
                if (extraFee >= 0)
                {
                    extraFee = value;
                }
            }
        }
        #region part02 Q3 
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + extraFee;

            }

        }
        #endregion
        #region part02 Q 4 override Print Shipment
        public override string PrintShipment()
        {
            Console.WriteLine("---Express Shipment---");
            return base.PrintShipment() + $"\n ExtraFee : {extraFee}";
        }
        #endregion
    }
}
