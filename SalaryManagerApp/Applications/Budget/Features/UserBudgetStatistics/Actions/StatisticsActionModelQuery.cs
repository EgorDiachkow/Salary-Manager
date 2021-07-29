namespace SalaryManagerApp.Applications.Budget.Features.UserBudgetStatistics.Actions
{
    using SalaryManagerApp.Applications.UserProfile.Actions;

    public class StatisticsActionModelQuery
    {
        public StatisticsActionModelQuery(
            UserProfileActionModel userProfile)
        {
            this.UserProfile = userProfile;
        }

        public interface IHandler
        {
            StatisticsActionModel Handle(
                StatisticsActionModelQuery query);
        }

        public UserProfileActionModel UserProfile { get; }
    }
}