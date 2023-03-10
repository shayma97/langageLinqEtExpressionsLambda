using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string PassportNumber { get; set; }

        public DateTime Birthdate { get; set; }

        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }

        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "FirstNamr" + FirstName + "LastName" + LastName +
                "EmailAddress" + EmailAddress + "PassportNumber" + PassportNumber;
        }

        //Polymorphysme par signature
        public bool CheckProfile(string lastName, string firstName)
        {
            return FirstName == firstName && LastName.Equals(lastName);
        }

        public bool CheckProfile(string lastName, string firstName, string email)
        {
            // return FirstName == firstName && LastName.Equals(lastName) && EmailAddress==email;
            return CheckProfile(lastName, firstName) && EmailAddress.Equals(email);
        }


        public bool Login(string lastName, string firstName,string email)
        {
            if(email!= null)
            {
                return CheckProfile(firstName, LastName, email);
               
            }
            return CheckProfile(firstName, lastName);
        }

        // virtual : methode qu'on peux redéfinir
        public virtual void PassengerType()
        {
            Console.WriteLine("I am passenger");

        }
    }

  
}
