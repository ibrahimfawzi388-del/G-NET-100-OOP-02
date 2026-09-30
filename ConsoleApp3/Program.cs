using System.Diagnostics.Metrics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions Question 1
            // a: Difference between Class and Struct
            //A class is a reference type, while a struct is a value type.
            //A class supports inheritance and polymorphism, while a struct does not support class inheritance. 
            // b: Why are classes more suitable for large applications?
            //Classes are more suitable because they support inheritance, polymorphism, and access modifiers such as public, private, protected, and internal.
            //They promote code reuse, provide better control over data access
            #endregion

            #region Theoretical Questions Question 2
            //a) Which class is the parent class? Shipmet 
            //b) Which class is the child class? ExpressShipment
            //c) What members are inherited by ExpressShipment? TrackingCode
            //d) Why is inheritance better than duplicating the same code in multiple? Inheritance promotes code reuse, reduces code duplication,
            //and makes the code easier to maintain and modify.
            #endregion

            #region Console Application 
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            Console.WriteLine("enter delivery center name");
            deliveryCenter.CenterName = Console.ReadLine();


            StandardShipment standardShipment=new StandardShipment();
            ExpressShipment expressShipment=new ExpressShipment();
            InternationalShipment internationalShipment=new InternationalShipment();

            Console.WriteLine("enter trackingcode");
            standardShipment.trackingcode = Console.ReadLine();
            Console.WriteLine("enter description");
            standardShipment.description = Console.ReadLine();
            Console.WriteLine("enter weight");
            standardShipment.weight=decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter delivery fee");
            standardShipment.deliveryfee=decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter extra fee");
            expressShipment.extraFee=decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter trackingcode");
            expressShipment.trackingcode = Console.ReadLine();
            Console.WriteLine("enter description");
            expressShipment.description = Console.ReadLine();
            Console.WriteLine("enter weight");
            expressShipment.weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter delivery fee");
            expressShipment.deliveryfee = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter customs fee");
            internationalShipment.customsfee=decimal.Parse(Console.ReadLine());
            Console.WriteLine("destination country");
            internationalShipment.destinationcountry = Console.ReadLine();
            Console.WriteLine("enter trackingcode");
            internationalShipment.trackingcode = Console.ReadLine();
            Console.WriteLine("enter description");
            internationalShipment.description = Console.ReadLine();
            Console.WriteLine("enter weight");
            internationalShipment.weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter delivery fee");
            internationalShipment.deliveryfee = decimal.Parse(Console.ReadLine());

            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);

            Console.WriteLine($"delivery center : {deliveryCenter.CenterName}");
            deliveryCenter.PrintAllShipments();

            Console.WriteLine("enter code because search");
            string code=Console.ReadLine();
            if (deliveryCenter[code]!= null)
            {
                Console.WriteLine($"the shipment is available {code}-{deliveryCenter[code].description}");
            }
            else
            {
                Console.WriteLine($"the shipment is not available");
            }


            Console.WriteLine("Enter Tracking Code to remove");
            code = Console.ReadLine();
            if (deliveryCenter.RemoveShipment(code))
            {
                Console.WriteLine("Remaining Shipments");
            }
            else
            {
                Console.WriteLine($"the shipment is not available");
            }



            deliveryCenter.PrintAllShipments();
            #endregion
        }
    }
}
