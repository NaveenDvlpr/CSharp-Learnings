using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 900000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.000001f;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            string name = "aba";
            char letter = 'z';

            Console.WriteLine(name);
            Console.WriteLine(letter)

            string textAge = "23";
            age = Convert.ToInt32(textAge);
            bigNumber = Convert.ToInt64(textAge);
            negative = Convert.ToDouble(textNegative);
            precision = Covert.ToSingle(textPrecision);
            money = Conver.ToDecimal(textMoney);


            bool value = true;
            Console.WriteLine(value);

            age++;
            age--;

            name += " is Programming.";

            // Char addition does add the unicode values of the character arguements

            var age; // doesnt mean anything
            var age = 32;
            var bigNumber = 90000L;

            Console.WriteLine


        }
    }
}