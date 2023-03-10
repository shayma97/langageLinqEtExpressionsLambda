using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interface
{
    public interface IServiceFlight
    {
        IList<DateTime> GetFlightsDates(string destination);

        void ShowFlightDetails(Plane plane);
       int ProgrammedFlightNumber(DateTime startDate);

        double DurationAverage(string destination);

        IEnumerable<Flight> OrderedDurationFlights();
    }
}
