namespace Mytest.Characteristics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class PhoneDefaultBase : IPhoneDefault, IHardwareWork, IDisplay, IOs
    {
        public string Color { get; private set; }

        public string Model { get; private set; }

        public abstract void Call(string number);

        public abstract void ReceiveCall();

        public abstract void Sms(string text, string number);

        public virtual void DisplayOn()
        {
            Console.WriteLine("Display On");
        }

        public virtual void DisplayOff()
        {
            Console.WriteLine("Display Off");
        }

        public virtual void Battery(int level = 0, bool status = true)
        {
            if (level < 100)
            {
                Console.WriteLine("Battery Medium");
            }
            else if (level <= 30)
            {
                Console.WriteLine("Battery Low");
            }
            else if (level <= 0)
            {
                status = false;
            }        
        }

        public virtual void TurnOff()
        {            
            Console.WriteLine("Phone off...\n");

            this.DisplayOff();
        }

        public virtual void TurnOn()
        {
            this.DisplayOn();

            Console.WriteLine("Phone on...");
        }
                
        public abstract void Process();

        public abstract void Ram();

        public virtual void NameOs(string name)
        {
            Console.WriteLine("Name OS: {0}", name);
        }

        public virtual void VenderOs(string name)
        {
            Console.WriteLine("Venser OS: {0}", name);
        }

       public PhoneDefaultBase(string model, string color)
        {
            this.Model = model;

            this.Color = color;

            Console.WriteLine("Phone Constructor");
        }
    }
}