using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public DateOnly EmployementDate { get; set; }

        public string Fonction { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return "EmployementDate= "+ this.EmployementDate + "salary= " + this.Salary + "Fonction= " + this.Fonction;
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("im a staff member");
        }

    }
}
