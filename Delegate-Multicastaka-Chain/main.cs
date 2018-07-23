using System;

delegate int Callback(int a, int b);

class MainClass {
  static int Sum(int i, int j) {
    Console.WriteLine("Sum");
    return i + j;
  }

  static int Multiply(int i, int j) {
    Console.WriteLine("Multiply");
    return i * j;
  }

  static int Power(int i, int j) {
    Console.WriteLine("Power");
    return (int)Math.Pow((double)i, (double)j);
  }

  public static void Main (string[] args) {
    Callback cb;
    cb = Sum;
    Console.WriteLine (cb(1, 2) == 3);

    cb = delegate (int i, int j) { return i + j; }; // 익명함수
    Console.WriteLine (cb(1, 2) == 3);

    cb = (int i, int j) => { return i + j; }; // 람다식
    Console.WriteLine (cb(1, 2) == 3);

    cb = (i, j) => i+j;                       // 람다
    Console.WriteLine (cb(1, 2) == 3);

    Console.WriteLine("\tChain");
    cb = Sum;
    cb += Multiply;
    cb += Power;
    Console.WriteLine( cb(3, 2) );
    cb -= Power;
    Console.WriteLine( cb(3, 2) );
  }
}