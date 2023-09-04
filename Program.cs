using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please, enter the number:");
        double num = Convert.ToDouble(Console.ReadLine());
        double circumferenceOfCircle = 2 * Math.PI * num;
        Console.WriteLine("The result is: " + circumferenceOfCircle);

    }
}