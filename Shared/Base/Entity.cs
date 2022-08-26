namespace Shared.Base
{
    public abstract class Entity
    {
        public Entity()
        {
            ID = Guid.NewGuid();
        }

        public Entity(Guid id)
        {
            ID = id;
        }

        public Guid ID { get; set; }
    }
}