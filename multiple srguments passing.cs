// passing more number of arguments uisng key:value Syntax

using System;
public class Vignesh
{
    static void Parent(string Child1 , string Child2 , string Child3)
    {
        Console.WriteLine("THE ELDER CHILD IS " +Child1);
        Console.WriteLine("THE YOUNGER CHILD IS " +Child3);
    }
    static void Main(string[] args){
        Parent(Child1:"Vignesh",Child2:"Kamal",Child3:"Raja");
    }
}