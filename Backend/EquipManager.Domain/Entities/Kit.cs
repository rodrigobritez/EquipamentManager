using EquipManager.Domain.ValueObjects;

namespace EquipManager.Domain.Entities
{
    public class Kit : Entity
    {
        public Kit(int id, List<Equipment> equipments, bool available, Local local) : base(id)
        {
            Equipments = new List<Equipment>();
            Equipments = equipments;
            Available = available;
            Local = local;
        }

        public List<Equipment> Equipments { get; private set; }
        public bool Available { get; private set; }
        public Local Local { get; private set; }

        public void ChangeAvailability()
        {
            Available = !Available;
        }

        public void ChangeLocal(Local local)
        {
            Local = local;
        }

        public void AddEquipment(Equipment equipment)
        {
            Equipments.Add(equipment);
        }

        public void RemoveEquipment(Equipment equipment)
        {
            Equipments.Remove(equipment);
        }

        public void ChangeEquipment(Equipment equipment)
        {
            var index = Equipments.FindIndex(e => e.Id == equipment.Id);
            Equipments[index] = equipment;
        }

    }
}