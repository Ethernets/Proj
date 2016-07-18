namespace Mytest.Characteristics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Phone : IPhoneDefault
    {
        public abstract void Battery(int x);

        public abstract void Call(string number);

        public abstract void Process();

        public abstract void Ram();

        public abstract void ReceiveCall();

        public abstract void Sms(string text, string number);

        public virtual void TurnOff()
        {
        }

        public virtual void TurnOn()
        {
        }
    }
}