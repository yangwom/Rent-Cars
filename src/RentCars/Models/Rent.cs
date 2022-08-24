using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }

    public double Percentage = 0.10;

    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        Vehicle = vehicle;
        Person = person;
        DaysRented = daysRented;
        Vehicle.IsRented = true;
        Person.Debit = Price;
        Status = RentStatus.Confirmed;

        if (person is PhysicalPerson)
        {
            Price = vehicle.PricePerDay * DaysRented;
        }
        if (person is LegalPerson)
        {
            Price = vehicle.PricePerDay * DaysRented * Percentage;


        }
    }

    public void Cancel()
    {
        Status = RentStatus.Cancelled;
    }

    public void Finish()
    {
        Status = RentStatus.Finished;

    }
}
