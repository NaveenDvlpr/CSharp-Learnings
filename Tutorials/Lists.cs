using System;
using System.Collections.Generic;
class Lists {
  static void lists() {
      listsIntro();
  }
  
  static void listsIntro() {
      List<int> numbers = new List<int>();
      Console.Write("Enter number of values: ");
      int n = Convert.ToInt32(Console.ReadLine());
      for(int i = 0; i < n; i++) 
        numbers.Add(Convert.ToInt32(Console.ReadLine()));
      foreach(int num in numbers) 
        Console.Write($"{num} ");
  }
}