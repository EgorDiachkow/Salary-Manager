namespace SalaryManagerApp.Applications.Budget.Features.UserBalance.Adapters
{
    using SalaryManagerApp.Applications.Budget.Features.UserBalance.Actions.UserFundList;
    using SalaryManagerApp.Applications.Budget.Features.UserBalance.Adapters.InfrastructureContract;

    public class UserFundListActionModelQueryHandler
        : UserFundListActionModelQuery.IHandler
    {
        private readonly UserFundListSummaryDataModelQuery.IHandler userFundListSummaryDataModelQueryHandler;

        public UserFundListActionModelQueryHandler(
            UserFundListSummaryDataModelQuery.IHandler userFundListSummaryDataModelQueryHandler)
        {
            this.userFundListSummaryDataModelQueryHandler = userFundListSummaryDataModelQueryHandler;
        }

        public UserFundListActionModel Handle(
            UserFundListActionModelQuery query)
        {
            var data = this.userFundListSummaryDataModelQueryHandler
                .Handle(
                    query: new UserFundListSummaryDataModelQuery());

            return new UserFundListActionModel(
                userCashValue: data.UserCashValue,
                userObligationsValue: data.UserObligationsValue,
                userCreditcardItems: data.UserCreditcardItems,
                userCashCategoryItems: data.UserCashCategoryItems,
                userObligationCategoryItems: data.UserObligationCategoryItems,
                userSavingCategoryItems: data.UserSavingCategoryItems);
        }
    }
}
