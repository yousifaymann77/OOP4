using System;
using System.Collections.Generic;
using System.Text;

namespace oop4Assign
{
    internal class StandardShipment : Shipment , ITrackable ,IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal deliveryFee, decimal weight)
        : base(trackingCode, description, deliveryFee, weight)
        {
        }

        #region part02 Q3 
        public override decimal EstimatedCost
        {
            get
            {
                return (Weight * 5) + DeliveryFee;
            }
        }

        #region part02 Q5
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        } 
        #endregion

        #region part02 Q4
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is out for Delivery ";
        } 
        #endregion

        public override void PrintShipment()
        {
            Console.WriteLine("---Standard Shipment---");
            Console.WriteLine($"Tracking Code: {TrackingCode},\n" +
                              $" Description: {Description},\n" +
                              $" Weight: {Weight} kg,\n" +
                              $" Delivery Fee: ${DeliveryFee},\n" +
                              $" Estimated Cost: ${EstimatedCost}");
        } 
        #endregion

    }
}
