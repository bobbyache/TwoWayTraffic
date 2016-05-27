using System;
using System.Collections.Generic;
using System.Text;

namespace CygX1.TwoWay.GameBaseEngine
{
    public class ConveyerBeltEventArgs
    {
        public readonly IPipelineTraveller Traveller;
        public ConveyerBeltEventArgs(IPipelineTraveller travellingObject)
        {
            Traveller = travellingObject;
        }
    }
}
