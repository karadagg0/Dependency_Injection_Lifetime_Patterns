namespace Dependency_Injection_Lifetime_Patterns
{
    public class UserLoginDate:IUserLoginDate
    {
        public  int UserId { get; }
        private readonly string userName;
        private readonly DateTime loginDate;
        private readonly IUserIdGenerator _userIdGenerator; 
        public UserLoginDate(IUserIdGenerator userIdGenerator)
        {
            userName = $"User{Guid.NewGuid().ToString("N")[..5]}";
            loginDate = DateTime.Now;
            _userIdGenerator = userIdGenerator;
        }

        public string GetUserDetails()
        {
            return $"UserName : {userName} - LoginTime: {loginDate} UserId:{_userIdGenerator.Id}";
        }
    }

    public interface IUserLoginDate
    {
        public int UserId { get; }
        string GetUserDetails();
    }
}
