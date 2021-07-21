namespace SalaryManagerApp.Applications.Budget.Features.UserBudgetStatistics.Actions
{
    public class CategoryItemModel
    {
        public CategoryItemModel(
            long categoryBalanceExpend,
            long categoryBalanceIncome,
            string categoryName,
            string categoryImage,
            CategoryType categoryType,
            long categoryBalanceExpendLimit)
        {
            this.CategoryBalanceExpend = categoryBalanceExpend;
            this.CategoryBalanceIncome = categoryBalanceIncome;
            this.CategoryName = categoryName;
            this.CategoryImage = categoryImage;
            this.CategoryType = categoryType;
            this.CategoryBalanceExpendLimit = categoryBalanceExpendLimit;
        }

        public string CategoryName { get; }

        public string CategoryImage { get; }

        public CategoryType CategoryType { get; }

        public long CategoryBalanceIncome { get; }

        public long CategoryBalanceExpend { get; }

        public long CategoryBalanceExpendLimit { get; }
    }
}
