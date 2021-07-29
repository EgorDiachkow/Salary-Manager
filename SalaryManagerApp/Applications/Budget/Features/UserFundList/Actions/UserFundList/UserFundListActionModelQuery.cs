namespace SalaryManagerApp.Applications.Budget.Features.UserFundList.Actions.UserFundList
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