using System;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;

class Program 
{

    public class CustomException : Exception
    {
        public CustomException() : base() { }
        public CustomException(string message) : base(message) { }
        public CustomException(string message, Exception e) : base(message, e) { }

        public static class ErrorCodes
        {
            public static readonly CustomException test1 = new CustomException("test1");
        }
    }
    static void Main(string[] args)
    {

        int a = 1;
        if(a is 1)
        {
            try
            {
                a = a / 0;
            }
            catch (Exception ex)
            {
                //throw CustomException.ErrorCodes.test1;
                Console.WriteLine(ex.ToString());
            }
            
        }

        else
        {
            Console.WriteLine("no");            
        }
    }

}

class Animal
{
    public virtual void makeNoise()
    {
        Console.WriteLine("zz");
        Console.WriteLine("3");

    }
}

class Cat : Animal
{
    public override void makeNoise()
    {
        Console.WriteLine("meow");
        Console.WriteLine("1");
        Console.WriteLine("2");
    }
}
