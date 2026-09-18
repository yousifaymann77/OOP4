using System;
using System.Collections.Generic;
using System.Text;

namespace oop4Assign
{
    internal class Driver
    {
        public Driver(int driverId, string fullName, string phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
        #region part02 Q5 
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        #endregion
    }
}
