namespace EquipManager.Domain.ValueObjects
{
    public class Local
    {
        public Local(int floor, int building)
        {
            Floor = floor;
            Building = building;
        }

        public int Floor { get; private set; }
        public int Building { get; private set; }
    }
}