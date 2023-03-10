using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        // des prop de base
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }

        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArival { get; set; }

        public string Destination { get; set; }

        public string Departure { get; set; }
        //des prop de navigation 

        public Plane Plane { get; set; }

        public IList<Passenger> Passengers { get; set; }


    }
}
