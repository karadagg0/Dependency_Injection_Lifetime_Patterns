namespace Dependency_Injection_Lifetime_Patterns
{
    public class UserIdGenerator:IUserIdGenerator
    {
        public int Id { get; set; }

        public UserIdGenerator()
        {
            Id = new Random().Next(1_000);
        }

    }
    public interface IUserIdGenerator
    {
       public int Id { get; }
    }
}
