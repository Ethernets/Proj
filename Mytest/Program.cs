namespace Mytest
{
    using System;
    using Mytest.Characteristics;
    using Mytest.Models;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Nokia n = new Nokia();
           // n.Display.DisplayOn();
           n.TurnOn();
            n.Call("102");

            Console.ReadKey();
        }
    }  
}
