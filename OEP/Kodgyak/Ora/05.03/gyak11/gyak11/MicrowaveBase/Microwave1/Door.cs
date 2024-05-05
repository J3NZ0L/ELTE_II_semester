namespace Microwave
{
    class Door
    {

        private Magnetron magnetron;
        private Lamp lamp;

        public bool Closed { get; private set; }

        public void Control(Lamp lamp, Magnetron magnetron) //iranyitja a kulonbozo komponenseket
        {
            this.magnetron = magnetron;
            this.lamp = lamp;
        }

        public void Open()
        {
            if (Closed)
            {
                Closed = false;
                lamp.Send(Signal.Opened);
                magnetron.Send(Signal.Opened);
            }
        }

        public void Close()
        {
            if (Closed)
            {
                Closed = true;
                lamp.Send(Signal.Closed);
                magnetron.Send(Signal.Closed);
            }
        }

        public override string ToString()
        {
            return "door " + (Closed ? "has been Closed" : "is open");
        }
    }
}
