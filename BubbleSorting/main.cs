using System;

class MainClass {
  public static void Main (string[] args) {
    int temp = 0;
    int[] array = new int[] {
      5, 2, 3, 1, 4
    };

    for(int k=0; k<array.Length; k++){
      Console.Write(array[k]);
    };

    Console.WriteLine("");

    for(int i=0; i<array.Length; i++){
      for(int j=1; j<array.Length-i; j++){
        if (array[j] < array[j-1]) {
          temp = array[j-1];
          array[j-1] = array[j];
          array[j] = temp;
        };
      };
    };

    for(int l=0; l<array.Length; l++){
      Console.Write(array[l]);
    };

  }
}