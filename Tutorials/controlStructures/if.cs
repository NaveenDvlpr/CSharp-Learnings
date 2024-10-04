using System;

namespace Sample {
    class Program {
        public static void main(string[] args) {
            int age = Convert.ToInt32(Console.ReadLine());
           // if(age >= 18) Console.WriteLine("Your Major");
           // else Console.WriteLine("Your Minor");

           if(age <= 1) Console.WriteLine("Your Infant");
           else if(age <= 10) Console.WriteLine("Your Kid");
           else if(age <= 19) Console.WriteLine("Your Teen");
           else Console.WriteLine("Your Adult");

           if(age >= 13 && age <= 19) Console.WriteLine("Your Teen");
        }
    }
}