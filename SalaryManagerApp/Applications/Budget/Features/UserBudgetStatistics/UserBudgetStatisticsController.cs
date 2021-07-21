namespace SalaryManagerApp.Applications.Budget.Features.UserBudgetStatistics
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using SalaryManagerApp.Applications.Budget.Features.UserBudgetStatistics.Actions;
    using SalaryManagerApp.Applications.Budget.Features.UserBudgetStatistics.Adapter;

    [ApiController]
    [Route(template: "[controller]")]
    public class UserBudgetStatisticsController
        : ControllerBase
    {
        private readonly ILogger<UserBudgetStatisticsController> _logger;

        public UserBudgetStatisticsController(
            ILogger<UserBudgetStatisticsController> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public StatisticsActionModel Get()
        {
            var data = new StatisticsActionModelQueryHandler()
                .Handle(
                    query: new StatisticsActionModelQuery());
            return data;
        }
    }
}