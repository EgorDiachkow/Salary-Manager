namespace SalaryManagerApp.Applications.Budget.Features.UserFundList.Actions.UserFundList
{
    public class UserSavingCategoryItemViewModel
    {
        public UserSavingCategoryItemViewModel(
            string savingName,
            long savingValue,
            string description)
        {
            this.SavingName = savingName;
            this.SavingValue = savingValue;
            this.Description = description;
        }

        public string SavingName { get; }

        public long SavingValue { get; }

        public string Description { get; }
    }
}