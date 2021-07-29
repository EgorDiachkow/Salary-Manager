namespace SalaryManagerApp.Applications.Budget.Features.UserFundList.InfrastructureContract
{
    using System.Collections.Generic;
    using SalaryManagerApp.Applications.Budget.Features.UserFundList.Actions.UserFundList;

    public class UserFundListSummaryDataModelQuery
    {
        public interface IHandler
        {
            ResultActive Handle(
                UserFundListSummaryDataModelQuery query);
        }

        public class ResultActive
        {
            public ResultActive(
                long userCashValue,
                long userObligationsValue,
                List<UserCashCategoryItemViewModel> userCashCategoryItems,
                List<UserObligationCategoryItemViewModel> userObligationCategoryItems,
                List<UserSavingCategoryItemViewModel> userSavingCategoryItems,
                List<UserCreditcardItemViewModel> userCreditcardItems)
            {
                this.UserCashValue = userCashValue;
                this.UserObligationsValue = userObligationsValue;
                this.UserCashCategoryItems = userCashCategoryItems;
                this.UserObligationCategoryItems = userObligationCategoryItems;
                this.UserSavingCategoryItems = userSavingCategoryItems;
                this.UserCreditcardItems = userCreditcardItems;
            }

            public long UserCashValue { get; }

            public long UserObligationsValue { get; }

            public List<UserCashCategoryItemViewModel> UserCashCategoryItems { get; }

            public List<UserObligationCategoryItemViewModel> UserObligationCategoryItems { get; }

            public List<UserSavingCategoryItemViewModel> UserSavingCategoryItems { get; }

            public List<UserCreditcardItemViewModel> UserCreditcardItems { get; }
        }
    }
}
