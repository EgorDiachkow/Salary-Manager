namespace SalaryManagerApp.Applications.Budget.Features.UserFundList.Actions.UserFundList
{
    public class UserCreditcardItemViewModel
    {
        public UserCreditcardItemViewModel(
            long creditcardDebt,
            long creditcardLimit,
            string creditcardName,
            string description)
        {
            this.CreditcardDebt = creditcardDebt;
            this.CreditcardLimit = creditcardLimit;
            this.CreditcardName = creditcardName;
            this.Description = description;
        }

        public string CreditcardName { get; }

        public long CreditcardLimit { get; }

        public long CreditcardDebt { get; }

        public string Description { get; }
    }
}
