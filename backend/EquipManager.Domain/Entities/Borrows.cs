namespace EquipManager.Domain.Entities
{
    public class Borrows
    {
        public Borrows(string holder, Equipment equipament, string owner)
        {
            Holder = holder;
            Equipament = equipament;
            Owner = owner;
        }
        public Borrows(string holder, Kit kit, string owner)
        {
            Holder = holder;
            Kit = kit;
            Owner = owner;
        }
        public string Holder { get; private set; }
        public Kit? Kit { get; private set; }
        public Equipment? Equipament { get; private set; }
        public string Owner { get; private set; }

    }
}