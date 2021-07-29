namespace SalaryManagerApp.Applications.Budget.Features.UserBalance.Actions.UserFundList
{
    public class UserFundListActionModelQuery
    {
        public interface IHandler
        {
            UserFundListActionModel Handle(
                UserFundListActionModelQuery query);
        }
    }
}