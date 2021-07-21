namespace SalaryManagerApp.Applications.MainProfile.Features.UserProfile.Actions.Profile
{
    public class UserProfileActionModel
    {
        public UserProfileActionModel(
            int userId,
            string userEmail,
            string userName)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.UserName = userName;
        }

        public int UserId { get; }

        public string UserEmail { get; }

        public string UserName { get; }
    }
}
