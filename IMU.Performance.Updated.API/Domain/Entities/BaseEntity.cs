namespace IMU.Performance.Updated.API.Domain.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; private set; }

        public DateTime DateCreated { get; protected set; }
    }
}
