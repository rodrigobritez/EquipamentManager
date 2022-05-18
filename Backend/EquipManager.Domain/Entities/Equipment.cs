using EquipManager.Domain.Enums;
using EquipManager.Domain.ValueObjects;

namespace EquipManager.Domain.Entities
{
    public class Equipment : Entity
    {
        public Equipment(int id, string name, bool available, EType type, Local local) : base(id)
        {
            Name = name;
            Available = available;
            Type = type;
            Local = local;
        }

        public Equipment(int id, string name, EType type, Local local, int kitId) : base(id)
        {
            Name = name;
            Available = true;
            Type = type;
            Local = local;
            KitId = kitId;
        }

        public string Name { get; private set; }
        public bool Available { get; private set; }
        public EType Type { get; private set; }
        public Local Local { get; private set; }
        public int KitId { get; private set; }

        public void ChangeAvailability()
        {
            Available = !Available;
        }

        public void ChangeKit(int kitId)
        {
            KitId = kitId;
        }

        public void ChangeLocal(Local local)
        {
            Local = local;
        }
    }
}