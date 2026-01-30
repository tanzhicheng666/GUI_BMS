using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace basic_knowledge
{
    public delegate void MessageHandler(string messageText);
    class Connection
    {
        public event MessageHandler MessageArrived;

        private Timer pollTimer;

        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
        }

        public void Connect() => pollTimer.Start();
        public void Disconnect() => pollTimer.Stop();

        private static Random random = new Random();

        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            int ramdomValue = random.Next(9);
            Console.WriteLine($"Checking for the new message. random value is {ramdomValue} !");
            
            if ((ramdomValue == 0) && (MessageArrived != null))
            {
                MessageArrived("Hello Mami! ");
            }
        }
    }

    public class Display
    {
        public void DisplayMessage(string messageText)
            => Console.WriteLine($"Message arrived: {messageText}");
    }
}
