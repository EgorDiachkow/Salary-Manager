namespace SalaryManagerApp.Applications.UserProfile.Infrastructure
{
    using SalaryManagerApp.Applications.UserProfile.Actions;

    public class UserProfileActionModelQueryHandler
        : UserProfileActionModelQuery.IHandler
    {
        public UserProfileActionModel Handle(
            UserProfileActionModelQuery query)
        {
            return new (
                userId: "1",
                userEmail: "Email",
                userName: "Egor",
                userBalance: 1000,
                totalExpend: 1000,
                totalIncome: 31,
                totalExpendLimit: 200);
        }
    }
}