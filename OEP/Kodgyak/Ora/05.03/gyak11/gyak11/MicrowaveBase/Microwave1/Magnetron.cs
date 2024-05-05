namespace Microwave
{
    class Magnetron
    {
        private Lamp lamp;
        private Door door;

        private bool working;

        public Magnetron(Lamp lamp, Door door)
        {
            this.lamp = lamp;
            this.door = door;
        }
        public void Send(Signal signal)
        {
            switch(signal)
            {
                case Signal.Pressed:
                    if(!working && door.Closed)
                    {
                        working = true;
                        lamp.Send(Signal.Started);
                    }
                    else if(working)
                    {
                        working = false;
                        lamp.Send(Signal.Stopped);
                    }
                    break;
                case Signal.Opened:

                    break;

            }
        }

        public override string ToString()
        {
            return "magnetron " + (working ? "is working" : "is not working");
        }
    }
}
