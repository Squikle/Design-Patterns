using Builder.Classes;

namespace Builder.Abstractions
{
    abstract class Builder
    {
        public Table Table;

        public void CreateTable()
        {
            Table = new Table();
        }
        public abstract void CreateTop();
        public abstract void CreateLegs();
    }
}
