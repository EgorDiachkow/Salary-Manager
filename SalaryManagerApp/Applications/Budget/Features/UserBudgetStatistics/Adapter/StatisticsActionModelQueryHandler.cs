namespace SalaryManagerApp.Applications.Budget.Features.UserBudgetStatistics.Adapter
{
    using System.Collections.Generic;
    using SalaryManagerApp.Applications.Budget.Features.UserBudgetStatistics.Actions;

    public class StatisticsActionModelQueryHandler
        : StatisticsActionModelQuery.IHandler
    {
        public StatisticsActionModel Handle(
            StatisticsActionModelQuery query)
        {
            var listCategory = new List<CategoryItemModel>();
            var categoryItem = new CategoryItemModel(
                categoryImage: "",
                categoryName: "Еда",
                categoryBalanceExpend: 100,
                categoryBalanceIncome: 1000,
                categoryBalanceExpendLimit: 2000,
                categoryType: CategoryType.Income);

            listCategory.Add(
                item: categoryItem);

            return new StatisticsActionModel(
                categoryListTransactions: listCategory,
                userBalance: query.UserProfile.UserBalance,
                totalExpend: query.UserProfile.TotalExpend,
                totalExpendLimit: query.UserProfile.TotalExpendLimit,
                totalIncome: query.UserProfile.TotalIncome);
        }
    }
}