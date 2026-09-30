using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class DeliveryCenter
    {
        private Shipment[]? Shipments;
        private bool[] position;
        public string CenterName;
        public DeliveryCenter()
        {
            Shipments = new Shipment[20];
            position = new bool[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < 20 && position[index])
                {
                    return Shipments[index];
                }
                return default;
            }
            set
            {
                if (index >= 0 && index < 20 && position[index])
                {
                    Shipments[index] = value;
                }
            }
        }
        public Shipment this[string code]
        {
            get
            {
                for (int i = 0; i < 20; i++)
                {
                    if (Shipments[i].trackingcode == code)
                    {
                        return Shipments[i];
                    }
                }
                return default;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < 20; i++)
            {
                if (!position[i])
                {
                    Shipments[i] = shipment;
                    position[i] = true;
                    
                     Console.WriteLine("shipment added Successfully");
                    
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string code)
        {
            for (int i = 0; i < 20; i++)
            {
                if (Shipments[i].trackingcode == code)
                {
                    Shipments[i] = default;
                    position[i] = false;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < 20; i++)
            {
                if (position[i])
                {
                    if (Shipments[i].GetType().Name == "StandardShipment")
                    {
                        Console.WriteLine("Standard Shipment");
                    }
                    else if (Shipments[i].GetType().Name == "ExpressShipment")
                    {
                        Console.WriteLine("Express Shipment");
                    }
                    else
                    {
                        Console.WriteLine("International Shipment");
                    }
                    Shipments[i].PrintShipment();
                }
            }
        }
    }
}
