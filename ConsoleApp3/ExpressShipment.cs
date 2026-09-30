using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class ExpressShipment:Shipment
    {
        private decimal ExtraFee;

        public decimal extraFee
        {
            set
            {
                ExtraFee = value >= 0 ? value : ExtraFee;
            }
            get
            {
                return ExtraFee;
            }
        }
        public decimal EstimatedCost
        {
            get => base.deliveryfee + (base.weight* 5)+extraFee;
        }
        public ExpressShipment() : base()
        {
            extraFee = default;
            base.weight = default;
            base.description = default;
            base.deliveryfee = default;
            base.Destination = default;
            base.trackingcode = default;
        }
    }
}
