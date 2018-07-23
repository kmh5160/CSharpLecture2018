using System;
using System.Threading;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
    Task<string> task = new Task<string>( () => {
      Thread.Sleep(100);
      Console.WriteLine("in Task");
      return "Task result";
    });
    task.Start();
    Console.WriteLine ("in Main");
    Console.WriteLine(task.Result == "Task result"); // block
  }
}