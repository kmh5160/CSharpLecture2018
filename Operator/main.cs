using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(120 << 1 == 240);
    Console.WriteLine(120 << 2 == 480);
    Console.WriteLine(-120 >> 1 == -60);

    uint a = 0;
    Console.WriteLine(~a == 4294967295);
    int ia = 0;
    Console.WriteLine(~ia == -1);

    int e = 0xF0 | 0x0F;
    Console.WriteLine(e);

    int i = 1;
    Console.WriteLine(++i == 2);
    Console.WriteLine(i++ == 2);
  }
}