namespace Microwave
{
    public enum Signal
    {
        Pressed,
        Opened,
        Closed,
        Started,
        Stopped,
    }
    class MicroWave
    {
        public Button button;
        public Magnetron magnetron;
        public Door door;
        public Lamp lamp;

        public MicroWave()
        {
            button = new Button();
            /* Nem erdemes igy biztositani konstruktorban hogy tudnak egymasrol a komponensek
            magnetron = new Magnetron(lamp, door);
            door = new Door(magnetron, lamp);
            */

            lamp = new Lamp();

            button.Control(magnetron);
            door.Control(lamp,magnetron);
            magnetron.Control(door,lamp);

        }
        public override string ToString()
        {
            return string.Format($"{magnetron,-25}, {lamp,-20}, {door,-25}");
        }
    }
}
