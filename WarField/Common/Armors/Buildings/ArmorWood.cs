namespace WarField.Common.Armors.Buildings
{
    public class ArmorWood : IArmorBuilding
    {
        public string Name { get; }
        public double Armor { get; }

        public ArmorWood()
        {
            Name = "Wood";
            Armor = 100;
        }
    }
}