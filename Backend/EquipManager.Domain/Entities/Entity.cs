namespace EquipManager.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

        public bool Equals(Entity? other)
        {
            return other != null && Id == other.Id;
        }
    }
}