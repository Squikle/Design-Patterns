namespace Builder.Classes
{
    class Carpenter
    {
        public Table CreateTable(Abstractions.Builder builder)
        {
            builder.CreateTable();
            builder.CreateLegs();
            builder.CreateTop();
            return builder.Table;
        }
    }
}
