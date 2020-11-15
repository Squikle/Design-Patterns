namespace Builder.Classes
{
    class WoodenTableBuilder : Builder
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
