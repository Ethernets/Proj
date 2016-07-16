namespace Mytest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPhone
    {
        IDisplay Display { get; set; }

        void TurnOn();

        void TurnOff();

        void Call(string number);

        void ReceiveCall();

        void Sms(string text, string number);

        void Os();

        void Battery(int x);

        void Processor();

        void Ram();
     }

    public interface IDisplay
    {
        void TurnOff();

        void TurnOn();
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Phone nokla = new Nokia(new LcdDisplay());

            nokla.Battery(50);

            Console.ReadKey();
        }
    }
    
    public class LcdDisplay : IDisplay
    {
        public void TurnOff()
        {
            Console.WriteLine("Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("On");
        }
    }

    public abstract class Phone : IPhone
    {
        public Phone(IDisplay d)
        {
            this.Display = d;
        }

        public IDisplay Display { get; set; }

        public abstract void Battery(int x);

        public abstract void Call(string number);

        public virtual void Os() 
        {
        }

        public virtual void Processor()
        {
        }

        public virtual void Ram()
        {
        }

        public abstract void ReceiveCall();

        public abstract void Sms(string text, string number);

        public virtual void TurnOff()
        {
            this.Display.TurnOff();
            this.Os();
            this.Ram();
            this.Processor();
        }

        public virtual void TurnOn()
        {
            this.Display.TurnOn();
            this.Processor();
            this.Ram();
            this.Os();
        }
    }

    public class Nokia : Phone
    {
        public Nokia(IDisplay display) : base(display)
        {
        }

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

        public override void Os()
        {
            Console.WriteLine("Symbian");
        }

        public override void Processor()
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
            base.Processor();
            base.Ram();
            base.Os();
        }

        public override void TurnOff()
        {
            base.TurnOff();
            base.Os();
            base.Processor();
            base.Ram();
        }
    }
}
