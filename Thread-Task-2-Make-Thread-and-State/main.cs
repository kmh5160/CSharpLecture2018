// using System;
// using System.Threading;

// class MainClass {
//   public static void Todo() {
//     Thread.Sleep(500);
//     Console.WriteLine("Todo: " + Thread.CurrentThread.ManagedThreadId);
//   }

//   public static void Main (string[] args) {
//     Thread t = new Thread(Todo);
//     Console.WriteLine("before start: " + t.ThreadState);
//     t.Start();
//     Console.WriteLine("after running: " + t.ThreadState);
//     t.Join();
//     Console.WriteLine("after join: " + t.ThreadState);

//     Thread t2 = new Thread(new ThreadStart(Todo));
//     t2.Start();
//   }
// }

using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Todo() {
    Thread.Sleep(500);
    Console.WriteLine("Todo: " + Thread.CurrentThread.ManagedThreadId);
  }

  public static void Main (string[] args) {
    Task task = Task.Run(Todo);
    task.Wait();

    Task task2 = Task.Run( () => {
      Thread.Sleep(500);
      Console.WriteLine("Todo: " + Thread.CurrentThread.ManagedThreadId);
    });
    task2.Wait();
  }
}