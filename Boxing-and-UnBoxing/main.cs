using System;

class Car{
  public string name;
}

class MainClass {
  public static void Main (string[] args) {
    object obj = 10;
    object obj2 = 10;
    Console.WriteLine(obj != obj2);

    int b = (int)obj;
    Console.WriteLine(b == 10);

    Car car = new Car();
    car.name = "Mini";
    object obj3 = car;
    Car car2 = (Car)obj3;
    car2.name = "BMW";
    Console.WriteLine(car.name == "BMW");
  }
}