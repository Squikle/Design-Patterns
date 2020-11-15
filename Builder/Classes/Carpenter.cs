namespace Builder.Classes
{
    class Carpenter
    {
        public Table CreateTable(Builder builder)
        {
            builder.CreateTable();
            builder.CreateLegs();
            builder.CreateTop();
            return builder.Table;
        }
    }
}
