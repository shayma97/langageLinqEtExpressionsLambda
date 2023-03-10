using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Service
{
    public class ServiceFlight : IServiceFlight
    {
        //prop double tab
        public IList<Flight> Flights{ get; set; } = new List<Flight>();

        IList<DateTime> IServiceFlight.GetFlightsDates(string destination)
        {

            /*   List<DateTime> flighDates = new List<DateTime>();

               foreach (Flight flight in Flights)
               {
                   if (flight.Destination == destination)
                   {
                       flighDates.Add(flight.FlightDate);
                   }
               }
   */

            var query = from f in Flights
                        where f.Destination == destination
                        select f.FlightDate;
            return query.ToList();



        }

        public void ShowFlightDetails(Plane plane)
        {
            var query = from f in Flights
                        where f.Plane == plane
                        select new { f.FlightDate, f.Destination };
            foreach (var item in query)
            {
                Console.WriteLine("Flight date "+ item.FlightDate+ " "+ " Destination "+item.Destination);
            }
                         
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {   //LINK
            /*var query = from f in Flights
                        where (f.FlightDate - startDate).Days < 7
                        select f;
            
            return query.Count();*/

            //Lambda
            // return Flights.Where(f=> ((f.FlightDate - startDate).Days < 7)).Count();
            return Flights.Count(f => ((f.FlightDate - startDate).Days < 7));
        }

      

       public double DurationAverage(string destination)
        {   //link
            /* var query = from f in Flights
                         where f.Destination == destination
                         select f.EstimatedDuration;

             return query.Average();*/

            return Flights.Where(f => f.Destination == destination).Average(f => f.EstimatedDuration);
        }

       

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            //LINK
           /* var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query; */  
            
            //lamda expression
            /** Syntaxe
             * 
             * return Colletion.Where(a=> a.destination== dest).Select(f=>f.flightDate)
            */

            return Flights.OrderByDescending(f => f.EstimatedDuration);
        }
    }
}
