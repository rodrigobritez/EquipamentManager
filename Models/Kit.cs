namespace EquipamentManager.Models
{
    public class Kit
    {
        Local Local { get; set; }

        public bool Borrowed { get; set; }

        public IList<Equipment> Equipaments { get; set; }

    }
}