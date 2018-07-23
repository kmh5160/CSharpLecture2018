using System;
using System.Threading;

// lock에 사용되면 안 되는 object
// 1. thisLock
// 2. string
// 3. GetType(): Type

class Counter {
  public int Count { get; set; }
  readonly object thisLock = new object();
  public void Increase() {
    lock (thisLock) {
      Count++;
    }
  }
}

class MainClass {
  public static void Main (string[] args) {
    Counter c = new Counter();
    Thread t = new Thread(c.Increase);
    Thread t2 = new Thread(c.Increase);
    Thread t3 = new Thread(c.Increase);
    t.Start();
    t2.Start();
    t3.Start();

    Console.ReadLine();
  }
}