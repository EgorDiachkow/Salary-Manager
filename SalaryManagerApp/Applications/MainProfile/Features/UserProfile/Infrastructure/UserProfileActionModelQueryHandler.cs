namespace SalaryManagerApp.Applications.MainProfile.Features.UserProfile.Infrastructure
{
    using SalaryManagerApp.Applications.MainProfile.Features.UserProfile.Actions.Profile;

    public class UserProfileActionModelQueryHandler
        : UserProfileActionModelQuery.IHandler
    {
        public UserProfileActionModel Handle(
            UserProfileActionModelQuery query)
        {
            return new (
                userId: 1,
                userEmail: "Email",
                userName: "Egor");
        }
    }
}
