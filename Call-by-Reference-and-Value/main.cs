using System;

class MainClass {
  public static void Swap(ref int a, ref int b) {
    int temp = a;
    a = b;
    b = temp;
  }

  public static void Sum(int a, int b, out int sum){
    sum = a + b;
  }

  public static void Main (string[] args) {
    int a = 10;
    int b = 20;
    Swap(ref a, ref b);
    Console.WriteLine(a == 20 && b == 10);
    
    // int s = 0;
    // Sum(10, 20, ref s);
    // Console.WriteLine(s == 30);

    int sum;
    Sum(10, 20, out sum);
    Console.WriteLine(sum == 30);
  }
}