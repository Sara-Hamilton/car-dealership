using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string FuelType;

  public Car(string automobileMakeModel, int automobilePrice, int automobileMiles, string automobileFuelType = "Unleaded")
  {
    MakeModel = automobileMakeModel;
    Price = automobilePrice;
    Miles = automobileMiles;
    FuelType = automobileFuelType;
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", 114991, 7864);
    Car ford = new Car("2011 Ford F450", 55995, 14241, "Diesel");
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

    List<Car> Cars = new List<Car>() {porsche, ford, lexus, mercedes };
    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.MakeModel);
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.Price < maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}
