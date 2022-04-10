using System;

namespace DataAccess.DomainModels
{
    public class Entity : IEntity, IEquatable<Entity>
    {
        public int Id { get; set; }

        public bool Equals(Entity other)
        {
            return other != null && Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Entity);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}