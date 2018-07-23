using System;

class MainClass {
  public static void Main (string[] args) {
    int[] scores = new int[] {
      1, 1, 1, 2, 1, 2, 3, 3, 3, 3, 1, 1, 3, 4, 4, 1, 1, 4, 4
    };

    Console.WriteLine(FrequencyOf(scores, 1) == 8 );
    Console.WriteLine(FrequencyOf(scores, 4) == 4 );
    Console.WriteLine(FrequencyOf(scores, 100) == 0 );

    Console.WriteLine(ValueOfMaxFreq(scores) == 1);
  }

  public static int FrequencyOf(int[] list, int v) {
    int count = 0;
    for (int i = 0; i<list.Length; i++){
      if (list[i] == v)
        count++;
    }
    return count;
  }

  public static int ValueOfMaxFreq(int[] v) {
    // int maxValue = 0;

    // for(int i=1; i<10000; i++){
    //   if (FrequencyOf(v, maxValue) < FrequencyOf(v, i)) {
    //     maxValue = i;
    //   }
    // }
    int maxValue = 0;
    int maxCount = 0;

    for (int i=0; i<v.Length; i++) {
      int count = FrequencyOf(v, v[i]);
      if ( count > maxCount ) {
        maxCount = count;
        maxValue = v[i];
      }
    }
    return maxValue;
  }

}