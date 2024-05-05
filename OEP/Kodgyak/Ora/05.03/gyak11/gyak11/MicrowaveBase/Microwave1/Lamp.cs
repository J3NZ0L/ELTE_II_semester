namespace Microwave
{
    class Lamp
    {
        bool light_is_on;

        public void Send(Signal signal)
        {
            switch (signal)
            {
                case Signal.Started:
                case Signal.Opened:
                    light_is_on = true;
                    break;
                case Signal.Closed:
                case Signal.Stopped:
                    light_is_on = false;
                    break;
            }
        }

        public override string ToString()
        {
            return "lamp " + (light_is_on ? "is lighting" : "is not lighting");
        }
    }
}
