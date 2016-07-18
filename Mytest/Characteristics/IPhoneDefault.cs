namespace Mytest.Characteristics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPhoneDefault
    {
        void TurnOn();

        void TurnOff();

        void Call(string number);

        void ReceiveCall();

        void Sms(string text, string number);
    }

    public interface IDisplay
    {
        void Display(bool x);
    }

    public interface IHardwareWork
    {
        void Battery(int x);

        void Process();

        void Ram();
    }

    public interface ILink
    {
        void OperatorLink(int level);

        void WLAN(int level);

        void Bluetooth(int level);
    }
}
