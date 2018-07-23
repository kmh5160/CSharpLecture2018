using System;

class MainClass {
  public static void Main (string[] args) {
    double a = 1;
    double b = 2;
    double c = 1;

    double D = b*b - 4*a*c;

    if (D==0){
      double sol = (-b + Math.Sqrt(D)) / (2*a);
      Console.WriteLine(a*sol*sol + b*sol + c == 0);
    }
  }
}