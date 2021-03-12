namespace TeduCoreApp.Data.Entities
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }

        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}