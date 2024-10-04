using System;
class Triangle {
  static void triangle() {
    const int angleCount = 3;
    int[] angles = new int[angleCount];
    for(int i = 0; i < angleCount; i++) {
        Console.Write($"Enter Angle{i+1}: ");
        angles[i] = Convert.ToInt32(Console.ReadLine());
    }
    int angleSum = 0;
    foreach(int angle in angles) angleSum += angle;
    if(angleSum == 180) Console.Write("Is a triangle");
    else Console.Write("Not a triangle");
  }
}