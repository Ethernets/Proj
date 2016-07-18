namespace Mytest.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Mytest.Characteristics;

    public class Nokia : Phone
    {
        public string Color { get; private set; }

        public string Model { get; private set; }

        public string Os { get; private set; }

        public override void Battery(int x)
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

        public override void TurnOn()
        {
            base.TurnOn();
            this.Process();
            this.Ram();
        }

        public override void TurnOff()
        {
            base.TurnOff();
            this.Process();
            this.Ram();
        }
    }
}
