using System;

namespace DataAccess.DomainModels
{
    public abstract class Entity : Entity<long>
    {
        //
    }

    public abstract class Entity<TKey> : IEntity<TKey>
    {
        private TKey _id;

        protected Entity()
        {
            //
        }

        protected Entity(TKey key)
        {
            _id = key;
        }

        object IEntity.Id
        {
            get => Id;
        }

        public TKey Id
        {
            get => _id;
            set => _id = value;
        }
    }
}