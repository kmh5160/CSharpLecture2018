using System;

class MainClass {
  enum Animal { Mouse, Cat, Bird, Dog=10, Lion };

  public static void Main (string[] args) {
    Animal a = Animal.Dog;
    Console.WriteLine(a);
    Console.WriteLine((int)a == 10);
    Console.WriteLine((int)Animal.Mouse == 0);
    Console.WriteLine((int)Animal.Lion == 11);
  }
}