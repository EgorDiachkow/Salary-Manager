namespace SalaryManagerApp.Applications.MainProfile.Features.UserProfile.Actions.Profile
{
    public class UserProfileActionModelQuery
    {
        public UserProfileActionModelQuery(
            int userId)
        {
            this.UserId = userId;
        }

        public interface IHandler
        {
            UserProfileActionModel Handle(
                UserProfileActionModelQuery query);
        }

        public int UserId { get; }
    }
}