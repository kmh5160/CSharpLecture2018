using System;

delegate int Callback(int a, int b);

class MainClass {
  static int Sum(int i, int j) {
    return i + j;
  }

  public static void Main (string[] args) {
    // Callback cb;
    // cb = Sum;
    Callback cb = new Callback(sum);
    Console.WriteLine (cb(1, 2) == 3);

    cb = delegate (int i, int j) { return i + j; }; // 익명함수
    Console.WriteLine (cb(1, 2) == 3);

    cb = (int i, int j) => { return i + j; }; // 람다식
    Console.WriteLine (cb(1, 2) == 3);

    cb = (i, j) => i+j;                       // 람다
    Console.WriteLine (cb(1, 2) == 3);

    Console.WriteLine( new Callback((i, j) => i+j)(10, 20) == 30);
  }
}