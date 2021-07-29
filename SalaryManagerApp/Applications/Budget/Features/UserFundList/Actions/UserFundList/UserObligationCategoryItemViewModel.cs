namespace SalaryManagerApp.Applications.Budget.Features.UserFundList.Actions.UserFundList
{
    public class UserObligationCategoryItemViewModel
    {
        public UserObligationCategoryItemViewModel(
            string obligationDescription,
            long obligationDebtValue,
            string obligationName)
        {
            this.ObligationDescription = obligationDescription;
            this.ObligationDebtValue = obligationDebtValue;
            this.ObligationName = obligationName;
        }

        public string ObligationName { get; }

        public long ObligationDebtValue { get; }

        public string ObligationDescription { get; }
    }
}