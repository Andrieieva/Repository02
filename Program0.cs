using System;
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} + {2} = {3}", num1, num2,num3, num1 + num2 + num3);
        Console.WriteLine("{0} - {1} - {2} = {3}", num1, num2, num3, num1 - num2 - num3);
        Console.WriteLine("{0} x {1} x {2} = {3}", num1, num2, num3, num1 * num2 * num3);
        Console.WriteLine("{0} / {1} / {2} = {3}", num1, num2, num3, num1 / num2 / num3);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
