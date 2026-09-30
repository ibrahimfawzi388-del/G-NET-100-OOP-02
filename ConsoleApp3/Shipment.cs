using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Shipment
    {
        string TrackingCode;
        string Description;
        decimal Weight;
        decimal DeliveryFee;
        public DeliveryAddress Destination { get; set; }

        public string trackingcode
        {
            get => TrackingCode;

            set
            {
                TrackingCode = !string.IsNullOrWhiteSpace(value) ? value : TrackingCode;
            }
        }

        public string description
        {
            get => Description;

            set
            {
                Description = !string.IsNullOrWhiteSpace(value) ? value : Description;
            }
        }

        public decimal weight
        {
            get => Weight;

            set
            {
                Weight = value > 0 ? value : Weight;
            }
        }
        public decimal deliveryfee
        {
            get => DeliveryFee;

            set
            {
                DeliveryFee = value > 0 ? value : DeliveryFee;
            }
        }

        public decimal EstimatedCost
        {
            get => DeliveryFee + (Weight * 5);
        }
        public Shipment() { }
        public Shipment(string TrackingCode)
        {
            trackingcode = TrackingCode;
            description = "Unknown";
            weight = 1;
            deliveryfee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(string trackingcode, string description, decimal weight, decimal deliveryfree, DeliveryAddress destination)
        {
            this.trackingcode = trackingcode;
            this.description = description;
            this.weight = weight;
            this.deliveryfee = deliveryfree;
            this.Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            deliveryfee = newFee;
        }
        public void PrintShipment()
        {
            Console.WriteLine($"tracking code is {trackingcode}");
            Console.WriteLine($"description {description}");
            Console.WriteLine($"weight {weight}");
            Console.WriteLine($"delivery fee {deliveryfee}");
            Console.WriteLine($"estimated code {EstimatedCost}");
        }
    }
}
