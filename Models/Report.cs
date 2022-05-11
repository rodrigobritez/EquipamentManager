namespace EquipamentManager.Models
{
    public class Report
    {
        public IList<Equipment> Equipments { get; set; }

        public Local Local { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Responsible { get; set; }

        public string Taker { get; set; }

    }
}