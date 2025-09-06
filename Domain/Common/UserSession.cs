namespace Domain.Common
{
    public interface IUserSession
    {
        int? UserId { get; }
        string UserName { get; }
        string DisplayName { get; }
        string Role { get; }
        bool IsAuthenticated { get; }
        void SetUser(int userId, string userName, string displayName, string role);
        void Reset();
    }

    public class UserSession : IUserSession
    {
        public int? UserId { get; private set; }
        public string UserName { get; private set; }
        public string DisplayName { get; private set; }
        public string Role { get; private set; }
        public bool IsAuthenticated => UserId.HasValue;

        public void SetUser(int userId, string userName, string displayName, string role)
        {
            UserId = userId;
            UserName = userName;
            DisplayName = displayName;
            Role = role;
        }

        public void Reset()
        {
            UserId = null;
            UserName = null;
            DisplayName = null;
            Role = null;
        }
    }
}