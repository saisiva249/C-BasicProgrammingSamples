using System;
using System.Threading;

namespace CsharpQuestions
{
    class Program
    {
        public static void Main()
        {
            Device D = new Device("Standard Drive");
            IoCommunication ioCommunication = new IoCommunication();//Publisher
            ControlPanel cp = new ControlPanel();//Subscriber
            LifeSignProcess lp = new LifeSignProcess();
            //Start with publisher
            ioCommunication.ConnectionEstablished += cp.OnConnectionEstablished;
            ioCommunication.ConnectionEstablished += lp.OnConnectionEstablished;
            ioCommunication.Connect();

        }

    }
    
    public class Device
    {
        public Device(string Name)
        {
            Console.WriteLine($"Device {Name} Added");
        }
    }

    /* using Userdefined EventArgs
    public class DeviceEventArgs : EventArgs
    {
        public string Name { get; set; }
    }
   */
      
    public class IoCommunication
    {
        //Declare an Delegate
        //Define an event based on delegate
        //Raise an event: we should define a method, of protected virtual void and name should start with "On"+Event Name
        /*public delegate void ConnectionEventHandler(object source, EventArgs args);
        public event ConnectionEventHandler ConnectionEstablished;*/

        


        //we can also use .net predefined event handlers for declaring the event
        public event EventHandler<EventArgs> ConnectionEstablished;
        //public event EventHandler<DeviceEventArgs> ConnectionEstablished;


        public void Connect()
        {
            Console.WriteLine("Connecting Device");
            Thread.Sleep(5000);
            OnConnectionEstablished();
        }

        protected void OnConnectionEstablished()
        {
            //if event is not null means any subsribers are there
            if(ConnectionEstablished!=null)
            {
                ConnectionEstablished(this, EventArgs.Empty);
            }

        }
    }


    public class ControlPanel
    {
        public void OnConnectionEstablished(object source, EventArgs args)
        {
            Console.WriteLine("Control Panel Activated");
        }
    }

    public class LifeSignProcess
    {
        public void OnConnectionEstablished(object source, EventArgs args)
        {
            Console.WriteLine("LifeSign Process Activated");
        }
    }

}



#region Delegate
//class Program
//{
//    public delegate float Calculate(int a, int b);
//    static void Main(string[] args)
//    {
//        Program p = new Program();
//        p.Calculator();
//        System.Console.Read();
//    }

//    public void Calculator()
//    {
//        Calculate c = new Calculate(Add);
//        c += new Calculate(Sub);
//        var result = c(5, 4);
//        System.Console.WriteLine("Result" + result);

//    }

//    public float Add(int a, int b)
//    {
//        System.Console.WriteLine("Add");
//        return a + b;
//    }

//    public float Sub(int a, int b)
//    {
//        System.Console.WriteLine("Sub");
//        return a - b;
//    }

//}
#endregion
