
using System;
class main
{
    static void Main()
    {
        float Fahrenheit, Celsius;
        Fahrenheit = 95;
        Celsius = ((Fahrenheit - 32) * 5) / 9;
        Console.WriteLine("Temperature in celsius is: " + Celsius);

        Celsius = 45;
        Fahrenheit = (Celsius * 9 / 5) + 32;
        Console.WriteLine("Tempreture in Fahrenheit is : " + Fahrenheit);

    }
    

}
