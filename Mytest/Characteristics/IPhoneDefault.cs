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
        void DisplayOn();

        void DisplayOff();
    }

    public interface IHardwareWork
    {
        void Battery(int level, bool status = false);

        void Process();

        void Ram();
    }

    public interface ILink
    {
        void OperatorLink(int level);

        void Wlan(bool status, string name);

        void Bluetooth(bool status);
    }

    public interface IOs
    {
        void NameOs(string name);

        void VenderOs(string name);
    }
}
