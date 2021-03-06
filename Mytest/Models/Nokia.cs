﻿namespace Mytest.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Mytest.Characteristics;

    public class Nokia : PhoneDefaultBase, ILink
    {
        public Nokia() : base ("Nokia 5800", "Black" )
        {
            Console.WriteLine("Nokia constructor");
        }

        public override void Battery(int x, bool status = true)
        {
            if (x <= 20)
            {
                Console.WriteLine("Battery low");
            }
            else if (x <= 50)
            {
                Console.WriteLine("Battery medium");
            }
            else if (x <= 100)
            {
                Console.WriteLine("Battery hight");
            }
            else
            {
                Console.WriteLine("Charged Battery");
            }
        }

        public override void Call(string number)
        {
            if (number != null)
            {
                Console.WriteLine("Nokia CAll {0}", number);
            }
            else
            {
                Console.WriteLine("Введите номер");
            }
        }

        public override void Process()
        {
            Console.WriteLine("434Mhz");
        }

        public override void Ram()
        {
            Console.WriteLine("1гб");
        }

        public override void ReceiveCall()
        {
            Console.WriteLine("Receive call");
        }

        public override void Sms(string text, string number)
        {
            Console.WriteLine("Text: {0} Number: {1}", text, number);
        }

        public void OperatorLink(int level)
        {
            Console.WriteLine("Connect Link");

            if (level < 20)
            {
                Console.WriteLine("Connect low Operator Link");
            } 
            else if (level <= 50)
            {
                Console.WriteLine("Connect medium Operator Link");
            }
            else if (level <= 100)
            {
                Console.WriteLine("Connect Operator Link Good");
            }
        }

        public void Wlan(bool status = false, string name = "disconnect")
        {
           if (status == true)
            {
                Console.WriteLine("Connect: {0}", name);
            }
        }

        public void Bluetooth(bool status = false)
        {
            if (status == true)
            {
                Console.WriteLine("Connect bluetooth");
            }
        }

        public override void NameOs(string name)
        {
            Console.WriteLine("Name OS: {0}", name);
        }

        public override void VenderOs(string name)
        {
            Console.WriteLine("Venser OS: {0}", name);
        }

        public override void TurnOn()
        {                      
            this.Process();
            this.Ram();
            this.NameOs("Symbian");
            this.VenderOs("Nokia");
        }

        public override void TurnOff()
        {
            this.Process();
            this.Ram();
        }
    }
}
