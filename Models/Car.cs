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

  public Car(string automobileMakeModel, int automobilePrice, int automobileMiles, string automobileFuelType = "Unleaded")
  {
    SetMakeModel(automobileMakeModel);
    SetPrice(automobilePrice);
    SetMiles(automobileMiles);
    SetFuelType(automobileFuelType);
  }
}

public class Program
{
  public static void Main()
  {
    // Car anotherCar = new Car();
    // anotherCar.SetMakeModel("2014 Porsche 911");
    // anotherCar.SetPrice(114991);
    // anotherCar.SetMiles(7864);
    // anotherCar.SetFuelType("Unleaded");
    // Console.WriteLine(anotherCar.GetMakeModel());
    // Console.WriteLine("Price: $" + anotherCar.GetPrice());
    // Console.WriteLine("Mileage: " + anotherCar.GetMiles());
    // Console.WriteLine("FuelType: " + anotherCar.GetFuelType());
    Car porsche = new Car("2014 Porsche 911", 114991, 7864);
    Car ford = new Car("2011 Ford F450", 55995, 14241, "Diesel");
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

    List<Car> Cars = new List<Car>() {porsche, ford, lexus, mercedes };
    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine("Price: $" + automobile.GetPrice());
      Console.WriteLine("Mileage: " + automobile.GetMiles());
      Console.WriteLine("FuelType: " + automobile.GetFuelType());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum milage: ");
    string stringMaxMilage = Console.ReadLine();
    int intMaxMilage = int.Parse(stringMaxMilage);

    List<Car> CarsMatchingSearch = new List<Car>();

    int counter = 0;
    foreach (Car automobile in Cars)
    {
      if ((automobile.GetPrice() < maxPrice) && (automobile.GetMiles() < intMaxMilage))
      {
        CarsMatchingSearch.Add(automobile);
      }
      else {
        counter ++;
      }
    }
    if (counter == Cars.Count)
    {
      Console.WriteLine("No matching Cars.");
    }


    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }
  }
}
