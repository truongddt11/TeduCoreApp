namespace TeduCoreApp.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { set; get; }

        public bool IsTransient()
        { return Id.Equals(default(T)); }
    }
}