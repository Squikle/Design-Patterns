namespace Builder.Classes
{
    class WoodenTableBuilder : Abstractions.Builder
    {
        public override void CreateLegs()
        {
            Table.Legs = "WoodenLegs";
        }

        public override void CreateTop()
        {
            Table.Top = "WoodenTop";
        }
    }
}
