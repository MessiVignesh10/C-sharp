// creating different mrthods for classes and accessing them
using System;
public class Vignesh{
    static void football(){
        Console.WriteLine("Hi Vignesh from football method");
    }
    static void Basketball(){
        Console.WriteLine("Hi Vignesh From BasketBall method");
    }
    static void Main(string[] args){
        football();
        Basketball();
        football();
        Basketball();
        football();
        Basketball();
    }
}