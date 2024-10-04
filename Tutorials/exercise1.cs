using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter Your Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello "+name);
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your Age: "+age);
    }
}