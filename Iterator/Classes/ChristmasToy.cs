namespace Iterator.Classes
{
    class ChristmasToy
    {
        public string Color { get; set; }

        public ChristmasToy(string color)
        {
            Color = color;
        }

        public override string ToString()
        {
            return Color;
        }
    }
}