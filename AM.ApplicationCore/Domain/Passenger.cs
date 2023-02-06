using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger

    {
        public DateOnly BirthDate { get; set; }

        public int PassportNumber { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TelNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }

        /* 
          public bool checkProfile(string firstName , string lastName)
        {
            return firstName == this.FirstName && lastName == this.LastName && EmailAddress == this.EmailAddress;    
        }
        */
        public bool checkProfile(string firstName, string lastName, string email)
        {
            if(email== null)
            {
                return firstName == this.FirstName && lastName == this.LastName;
            }
            else
            {
                return firstName == this.FirstName && lastName == this.LastName && email == this.EmailAddress;
            }
            
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("im a passenger");
        }



    }
}
