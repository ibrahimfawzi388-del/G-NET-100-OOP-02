using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class InternationalShipment: Shipment
    {
        string DestinationCountry;
        decimal CustomsFee;

        public string destinationcountry
        {
            set
            {
                DestinationCountry = !string.IsNullOrWhiteSpace(value) ? value : DestinationCountry;
            }
            get => DestinationCountry;
        }
        public decimal customsfee
        {
            set
            {
                CustomsFee=value>=0? value : CustomsFee;
            }
            get => CustomsFee;
        }
        public decimal EstimatedCost
        {
            get => base.deliveryfee + (base.weight * 5) + customsfee;
        }

        public InternationalShipment() : base()
        {
            destinationcountry = default;
            customsfee= default;
            base.weight = default;
            base.description = default;
            base.deliveryfee = default;
            base.Destination = default;
            base.trackingcode = default;
        }
    }

}
