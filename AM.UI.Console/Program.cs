// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

/* Plane Plane1= new Plane ();
Plane1.Capacity = 200;
Plane1.ManufactureDate = new DateTime(2023, 01, 21);
Plane1.PlaneType = PlaneType.airbus;

Plane Plane2 = new Plane(PlaneType.boing, 500, new DateTime(2022, 02, 05));
*/

Plane Plane3= new Plane()
    {
        Capacity= 3,
        ManufactureDate= new DateTime(2023,02,04),
        PlaneType= PlaneType.boing

    };

Passenger passenger1 = new Passenger
{
    FirstName = "iheb",
    LastName="baoueb",
    EmailAddress= "ihebbaoueb@esprit.tn"
};

Console.WriteLine(passenger1.checkProfile("iheb", "baoueb", "ihebbaoueb@esprit.tn"));

Traveller traveller1 = new Traveller
{
    FirstName = "iheb",
    LastName = "baoueb",
    Nationality = "tunisien"
};

Console.WriteLine("traveller1: ");
traveller1.PassengerType();

Staff staff1 = new Staff
{
    FirstName = "aa",
    LastName = "bb",
    Salary = 1.0
};
Console.WriteLine("Staff1 : ");
staff1.PassengerType();
