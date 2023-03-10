// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");
// utilisation des constructeurs
//Plane p1 = new Plane();
//p1.ManufactureDate = DateTime.Now;
//p1.Capacity = 200;
//p1.PlaneType = PlaneType.Boing;

//Plane p2 = new Plane(1000, DateTime.Now, PlaneType.Airbus);
//Plane p3 = new Plane(1200,PlaneType.Airbus);

// initialiseur d'objet 
Plane p4 = new Plane
{
    ManufactureDate = DateTime.Now,
   
};
Plane p5 = new Plane
{
    ManufactureDate = DateTime.Now,
    Capacity = 200, 

};

Passenger p1 = new Passenger
{
    LastName = "Test1",
    FirstName = "Test2",
    EmailAddress = "Test@test.com"
};

Staff s1 = new Staff
{
    FirstName = "Test",
    LastName = "Test",
    EmailAddress = "test",
    Birthdate = new DateTime(1997, 01, 15)
};
Traveller t1 = new Traveller
{
    FirstName = "Test",
    LastName = "Test",
};
Console.WriteLine(p1.CheckProfile("Test1", "Test2"));
Console.WriteLine(p1.CheckProfile("Test", "Test2","aaa"));
p1.PassengerType();
s1.PassengerType();
t1.PassengerType();