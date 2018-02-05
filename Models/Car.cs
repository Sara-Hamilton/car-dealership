using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _fuelType;

  public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }
  public int GetPrice()
  {
    return _price;
  }

  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public void SetFuelType(string newFuelType)
  {
    _fuelType = newFuelType;
  }
  public string GetFuelType()
  {
    return _fuelType;
  }

  // public Car(string automobileMakeModel, int automobilePrice, int automobileMiles, string automobileFuelType = "Unleaded")
  // {
  //   MakeModel = automobileMakeModel;
  //   Price = automobilePrice;
  //   Miles = automobileMiles;
  //   FuelType = automobileFuelType;
  // }
}

public class Program
{
  public static void Main()
  {
    Car anotherCar = new Car();
    anotherCar.SetMakeModel("2014 Porsche 911");
    anotherCar.SetPrice(114991);
    anotherCar.SetMiles(7864);
    anotherCar.SetFuelType("Unleaded");
    Console.WriteLine(anotherCar.GetMakeModel());
    Console.WriteLine("Price: $" + anotherCar.GetPrice());
    Console.WriteLine("Mileage: " + anotherCar.GetMiles());
    Console.WriteLine("FuelType: " + anotherCar.GetFuelType());
    // Car porsche = new Car("2014 Porsche 911", 114991, 7864);
    // Car ford = new Car("2011 Ford F450", 55995, 14241, "Diesel");
    // Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    // Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

    // List<Car> Cars = new List<Car>() {porsche, ford, lexus, mercedes };
    List<Car> Cars = new List<Car>() { anotherCar };
    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }
  }
}
