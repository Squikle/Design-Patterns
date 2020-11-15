namespace Builder.Classes
{
    class IronTableBuilder : Builder
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
