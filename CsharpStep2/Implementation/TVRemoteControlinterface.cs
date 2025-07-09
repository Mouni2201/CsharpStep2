using System;

namespace RemoteControlSystems
{
    //can create multiple interfaces.Rules provided in inteerface. we only define properties and methods,
    //we can't implement them.

    interface Iremote
    {
        //interface provide rules and wouldn't implement.
        void PowerOn();
        void PowerOff();
        void ChangeChannel(int channelNumber);
        void Increasevolume();

    }
    interface IRemotePrice
    {
        string getPriceDetails();

    }

    interface IRemoteLocationDetails
    {
        string getLocation();
    }

    //I would like to take contract rules from Iremote. In class we need to implement rules.
    class SonyRemote : Iremote, IRemotePrice //(ctrl+.)
    {
        public string getPriceDetails()
        {
            return "500Rupees";
        }
        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"Sony Tv changed to channel {channelNumber}");
        }
        public void Increasevolume()
        {
            Console.WriteLine("Sony Tv Increase Volume");
        }

        public void PowerOff()
        {
            Console.WriteLine("Sony Tv PowerOff");
        }

        public void PowerOn()
        {
            Console.WriteLine("Sony Tv PowerOn");
        }
    }

    class LGRemote : Iremote, IRemoteLocationDetails
    {
        public void ChangeChannel(int channelNumber)
        {
            Console.WriteLine($"LG Tv changed to channel {channelNumber}");
        }

        public string getLocation()
        {
            return "Hyderabad, India";
        }

        public void Increasevolume()
        {
            Console.WriteLine("LG Tv Increase Volume");
        }

        public void PowerOff()
        {
            Console.WriteLine("LG Tv PowerOff");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG Tv PowerOn");
        }
    }

    class program
    {
        static void main()
        {
            Iremote lgremote = new LGRemote();
            //here lgremote is not an instance of class. It is reference of interface
            //Iremote is contract of rules and new LGRemote is which is followed by the rules.
            lgremote.ChangeChannel(2);
            lgremote.PowerOn();

            Iremote sonyremote = new SonyRemote();
            sonyremote.ChangeChannel(9);
            sonyremote.PowerOff();

            IRemotePrice remotePrice = new SonyRemote();
            //remotePrice.getPriceDetails();
            string price = remotePrice.getPriceDetails();
            Console.WriteLine(price);

            IRemoteLocationDetails remoteLocationDetails = new LGRemote();
            //remoteLocationDetails.getLocation();
            string location = remoteLocationDetails.getLocation();
            Console.WriteLine(location);



        }
    }
}
