// if else Statement by comparing the length of two Strings
using System;

public class NewBaseType
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Firstnumber :");
        string Firstnumber = Console.ReadLine();
        Console.WriteLine("Enter the Secondnumber :");
        string Secondnumber = Console.ReadLine();
        

        if (Firstnumber.Length > Secondnumber.Length )
        {
            Console.WriteLine("First number is the greatest");
        }
        else
        {
            Console.WriteLine("Second Number is Greatest ");
        }

    }