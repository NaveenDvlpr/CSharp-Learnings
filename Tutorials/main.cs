using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


class Function {
    static void Main(string[] args) {
        List<string> shoppingList = new List<string> {
            "Milk", "Cake", "Eggs"
        };
        
        bool result = IndexOf(shoppingList, "cake", out int index);
        Console.WriteLine($"{result} {index}");
        
        
        int num = 0;
        test(out num);
        Console.WriteLine(num);
        
        string nameInput = "Aba";
        int ageInput = 23;
        string addressInput = "1 something road";
        
        PrintDetails(age: ageInput, 
                     address: addressInput, 
                     name: nameInput);
        
        int firstNum = ReadInt("Enter first number");
        int secondNum = ReadInt("Enter second number");
        
        Console.WriteLine("Sum: "+Add(firstNum, secondNum));
        
        string name = ReadString("Enter your name");
        int age = ReadInt("Enter your age");
        
        string details = UserDetails(name, age);
        Console.WriteLine(details);
        
    }
    
    static bool IndexOf(List<string> list, string search, out int index) {
        for(int i = 0; i < list.Count; i++) {
            if(list[i].ToLower().Equals(search)) {
                index = i;
                return true;
            }
        }
        index = -1;
        return false;
    }
    
    static bool TryParse(string numStr, out int result) {
        result = 0;
        return true;
    }
    
    static void test(out int num) {
        num = 5;
    }
    
    static void PrintDetails(string name, int age, string address) {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
    }
    
    static string UserDetails(string name, int age) {
        return $"My name is {name} and my age is {age}.";
    }
    
    static string ReadString(string message) {
        Console.Write($"{message}: ");
        return Console.ReadLine();
    }
    
    static int ReadInt(string message) {
        Console.Write($"{message}: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    static int Add(int a, int b = 3) {
        Console.WriteLine($"b= {b}");
        return a+b;
    }
    
    
}