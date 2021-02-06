namespace TeduCoreApp.Data.Entities
{
    public class DomainEntity<T>
    {
        public T ID { get; set; }

        public bool IsTransient()
        {
            return ID.Equals(default(T));
        }
    }
}