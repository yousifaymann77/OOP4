namespace oop4Assign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Theoritical 

            #region Q1 a)What is Abstraction in Object-Oriented Programming?
            //Abstraction is the process of hiding the implementation details and showing only the essential features to the user 
            #endregion

            #region Q1 b) Why is abstraction considered one of the four pillars of OOP?
            // Because it helps us to focus only on what an object does rather than how it does it which reduces complexity and make code easier to use 
            #endregion

            #region Q2 a) What is the difference between an Abstract Class and an Interface?
            // Abstract class can have fields andconstructors But the Interface does not and Abstract class is a base class type , interface represents only a contract
            #endregion

            #region Q2 b)  When would you choose an Interface instead of an Abstract Class?
            // when I want to define a contract or capability rather than a shared base class with common implementation
            #endregion

            #region Q2 c) Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // Class can Inherit from one abstract class But can implement multiple Interfaces
            #endregion

            #endregion

            #region Part02 Q8 Main Checklist 
            // a) standard shipment 
            StandardShipment standardShipment = new StandardShipment("SH00H", "Laptop", 190, 8.5m);

            // b) express Shipment
            ExpressShipment expressShipment = new ExpressShipment("SH01H", "Bag", 550, 7, 150);

            // c) International Shipment
            InternationalShipment internationalShipment = new InternationalShipment("SH11H", "Shoes", 1000, 12, "Egypt", 400);

            // d) create delivery center and add Shipments to it 
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);

            // e) print All Shipment details
            Console.WriteLine("------Shipments Details-----");
            deliveryCenter.PrintAllShipments();

             
            DeliveryReport report = new DeliveryReport();


            // f) Print tracking status of every shipment
            Console.WriteLine("------Tracking Status-----");

            report.PrintShipment(standardShipment);
            report.PrintShipment(expressShipment);
            report.PrintShipment(internationalShipment);


            // g) Print insurance cost of every shipment
            Console.WriteLine("-------- Insurance -------");

            report.PrintInsurance(standardShipment);
            report.PrintInsurance(expressShipment);
            report.PrintInsurance(internationalShipment);


            // h) Store shipments in ITrackable[] array
            ITrackable[] trackableShipments = {standardShipment,expressShipment,internationalShipment};

            Console.WriteLine("\n========== ITrackable Array ==========");

            foreach (ITrackable shipment in trackableShipments)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }


            // i) Store shipments in IInsurable[] array
            IInsurable[] insurableShipments = { standardShipment, expressShipment, internationalShipment };


            Console.WriteLine("--------- IInsurable Array --------");

            foreach (IInsurable shipment in insurableShipments)
            {
                Console.WriteLine($"Insurance: {shipment.CalculateInsurance()}");
            }



            #endregion
        }
    }
}
