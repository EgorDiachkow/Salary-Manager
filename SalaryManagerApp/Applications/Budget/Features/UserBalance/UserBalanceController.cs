namespace SalaryManagerApp.Applications.Budget.Features.UserBalance
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using SalaryManagerApp.Applications.Budget.Features.UserBalance.Actions.UserFundList;
    using SalaryManagerApp.Applications.Budget.Features.UserBalance.Adapters;
    using SalaryManagerApp.Applications.Budget.Features.UserBalance.Infrastructure;
    using SalaryManagerApp.Applications.UserProfile;

    [ApiController]
    [Route(template: "[controller]/{action}")]
    public class UserBalanceController
        : SalaryBaseController
    {
        private readonly ILogger<UserBalanceController> _logger;

        public UserBalanceController(
            ILogger<UserBalanceController> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public UserFundListActionModel GetUserFundList()
        {
            return new UserFundListActionModelQueryHandler(
                    userFundListSummaryDataModelQueryHandler: new UserFundListSummaryDataModelQueryHandler())
                .Handle(
                    query: new UserFundListActionModelQuery());
        }
    }
}
