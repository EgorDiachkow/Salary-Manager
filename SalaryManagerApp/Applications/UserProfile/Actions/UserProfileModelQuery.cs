namespace SalaryManagerApp.Applications.UserProfile.Actions
{
    public class UserProfileActionModelQuery
    {
        public UserProfileActionModelQuery(
            string userId)
        {
            this.UserId = userId;
        }

        public interface IHandler
        {
            UserProfileActionModel Handle(
                UserProfileActionModelQuery query);
        }

        public string UserId { get; }
    }
}