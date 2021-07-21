namespace SalaryManagerApp.Applications.Budget.Features.UserBudgetStatistics.Actions
{
    using System.Collections.Generic;

    public class StatisticsActionModel
    {
        public StatisticsActionModel(
            List<CategoryItemModel> categoryListTransactions,
            long userBalance,
            long totalIncome,
            long totalExpend,
            long totalExpendLimit)
        {
            this.CategoryListTransactions = categoryListTransactions;
            this.UserBalance = userBalance;
            this.TotalIncome = totalIncome;
            this.TotalExpend = totalExpend;
            this.TotalExpendLimit = totalExpendLimit;
        }

        public List<CategoryItemModel> CategoryListTransactions { get; }

        public long UserBalance { get; }

        public long TotalIncome { get; }

        public long TotalExpendLimit { get; }

        public long TotalExpend { get; }
    }
}
