using System;
using System.Collections.Generic;
using System.Text;

namespace oop4Assign
{
    internal class ExpressShipment : Shipment , ITrackable ,IInsurable
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

        #region Part02 Q3 
        public override decimal EstimatedCost
        {
            get
            {
                return (Weight * 5) + DeliveryFee + extraFee;

            }

        }

        public override void PrintShipment()
        {
            Console.WriteLine("---Express Shipment---");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code: {TrackingCode},\n" +
                              $" Estimated Cost: ${EstimatedCost} EGP" +
                              $"\n ExtraFee : {extraFee}");
        }
        #endregion
        #region part02 Q4
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Being Prepared ";
        }
        #endregion
        #region part02 Q5
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m; 
        }
        #endregion
        

    }
}
