using System;
class Sort {
  static void sort() {
    int[] arr = new int[] {
      1,2,3,4,2,5  
    }; 
    
    Console.Write("Enter Number Search: ");
    int search = Convert.ToInt32(Console.ReadLine());
    
    // int res = Array.IndexOf(arr, search);
    int res = Array.IndexOf(arr, search,0, 2);
    Console.Write(res);
    
  }
  
  void arraySort() {
      int[] numbers = new int[] {
        5, 8, 1, 3, 7, 2, 6, 4
    };
    
    Array.Sort(numbers);
    Array.Reverse(numbers);
    
    Array.Clear(numbers, 5, 3); // sets to default value
    
    foreach(int num in numbers) Console.Write($"{num} ");
  }
}