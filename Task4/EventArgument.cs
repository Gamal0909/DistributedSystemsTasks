using System;

namespace Task4
{
    public class EventArgument : EventArgs
    {
        public string message { get; set; }
        public EventArgument(string message)
        {
            this.message = message;
        }
    }
}
