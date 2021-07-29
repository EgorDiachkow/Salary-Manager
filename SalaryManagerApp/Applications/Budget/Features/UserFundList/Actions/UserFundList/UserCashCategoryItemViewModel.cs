namespace SalaryManagerApp.Applications.Budget.Features.UserFundList.Actions.UserFundList
{
    public class UserCashCategoryItemViewModel
    {
        public UserCashCategoryItemViewModel(
            string description,
            string cashName,
            long cashBalance)
        {
            this.Description = description;
            this.CashName = cashName;
            this.CashBalance = cashBalance;
        }

        public string CashName { get; }

        public long CashBalance { get; }

        public string Description { get; }
    }
}