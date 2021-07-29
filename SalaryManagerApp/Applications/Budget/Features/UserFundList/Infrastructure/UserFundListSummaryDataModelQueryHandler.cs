namespace SalaryManagerApp.Applications.Budget.Features.UserFundList.Infrastructure
{
    using System.Collections.Generic;
    using SalaryManagerApp.Applications.Budget.Features.UserFundList.Actions.UserFundList;
    using SalaryManagerApp.Applications.Budget.Features.UserFundList.Adapters.InfrastructureContract;

    public class UserFundListSummaryDataModelQueryHandler
        : UserFundListSummaryDataModelQuery.IHandler
    {
        public UserFundListSummaryDataModelQuery.ResultActive Handle(
            UserFundListSummaryDataModelQuery query)
        {
            return new UserFundListSummaryDataModelQuery.ResultActive(
                userCashValue: 0,
                userObligationsValue: 0,
                userCreditcardItems: new List<UserCreditcardItemViewModel>(),
                userCashCategoryItems: new List<UserCashCategoryItemViewModel>(),
                userObligationCategoryItems: new List<UserObligationCategoryItemViewModel>(),
                userSavingCategoryItems: new List<UserSavingCategoryItemViewModel>());
        }
    }
}
