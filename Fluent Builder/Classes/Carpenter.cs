namespace Fluent_Builder.Classes
{
    class Carpenter
    {
        private Table _table;

        public Carpenter CreateTable()
        {
            _table = new Table();
            return this;
        }

        public Carpenter WithTopMaterial(string topType)
        {
            _table.Top = topType;
            return this;
        }
        public Carpenter WithLegsMaterial(string legsType)
        {
            _table.Legs = legsType;
            return this;
        }

        public Table Build()
            => _table;
    }
}
