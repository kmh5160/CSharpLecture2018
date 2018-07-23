using System;

class MainClass {
  public static void Main (string[] args) {
    int sum = 0, i = 0;
    do {
      ++i;
      sum += i;
    } while(i < 10);

    Console.WriteLine("sum = " + sum);

    string[] names = {"ctkim", "chang", "kim"};
    foreach(string name in names)
     Console.WriteLine(name);

    int s = 1;
    switch(names[0]) {
      case "ctkim":
        Console.WriteLine(1);
        break;
      case "kim":
        Console.WriteLine(2);
        break;
    }

  }
}