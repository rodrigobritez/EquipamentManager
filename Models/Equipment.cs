using EquipamentManager.Enums;

namespace EquipamentManager.Models
{
    public class Equipment
    {
        public string Name { get; set; }

        public ETypes Type { get; set; }

        public bool Borrowed { get; set; }

        public int KitId { get; set; }

        public Local Local { get; set; }

    }
}