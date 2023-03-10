using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing , Airbus
    }
    public class Plane
    {
      
        #region exemples
        // attribut
        //public string name;
        //public string GetName()
        //{
        //    return name;    
        //}
        //public void SetName(string value ) 
        //{ name = value; }

        ////prop + 2tab
        //// prop de base : light version
        //public string Prenom { get; set; }

        //// full version :propfull + 2tab
        //private int number;

        //public int Number
        //{
        //    get { return number; }
        //    set { number = value; }
        //}

        ////secure version 
        //public int MyProperty { get; private set; }

        #endregion


        public int PlaneId { get; set; }
        public int Capacity { get; set; }
        public PlaneType PlaneType { get; set; }

        public DateTime ManufactureDate { get; set; }


        public override string ToString()
        {
            return "Capacity" + Capacity + "PlaneId" + PlaneId + "Date" + ManufactureDate;
        }

        public IList<Flight> Flights { get; set; }

    }
}
