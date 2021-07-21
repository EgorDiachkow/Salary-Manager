namespace SalaryManagerApp.Applications.Budget.Features.UserBudgetStatistics.Actions
{
    public class StatisticsActionModelQuery
    {
        public interface IHandler
        {
            StatisticsActionModel Handle(
                StatisticsActionModelQuery query);
        }
    }
}
