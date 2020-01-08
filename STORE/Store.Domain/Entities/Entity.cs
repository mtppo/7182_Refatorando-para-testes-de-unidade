using System;

namespace Store.Domain.Entities
{
    public class Entity : IComparable
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}