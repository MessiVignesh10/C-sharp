using System;

public class NewBaseType
{
    public static void Main(String args[])
    {
        Console.WriteLine("Enter the Firstnumber :");
        Console.WriteLine("Enter the Secondnumber :");
        int Secondnumber = Console.ReadLine();
        int Firstnumber = Console.ReadLine();

        if (Firstnumber > Secondnumber)
        {
            Console.WriteLine("First number is the greatest");
        }
        else
        {
            Console.WriteLine("Second Number is Greatest ");
        }

    }
}
