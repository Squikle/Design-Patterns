namespace Builder.Classes
{
    class IronTableBuilder : Abstractions.Builder
    {
        public override void CreateLegs()
        {
            Table.Legs = "IronLegs";
        }

        public override void CreateTop()
        {
            Table.Top = "IronTop";
        }
    }
}
