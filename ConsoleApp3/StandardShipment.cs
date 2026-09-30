using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp3
{
    public class StandardShipment : Shipment
    {
        public StandardShipment():base()
        {
            base.weight = default;
            base.description = default;
            base.deliveryfee = default;
            base.Destination = default;
            base.trackingcode = default;
        }
    }
}
