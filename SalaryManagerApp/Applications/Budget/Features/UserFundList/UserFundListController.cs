namespace SalaryManagerApp.Applications.Budget.Features.UserFundList
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using SalaryManagerApp.Applications.Budget.Features.UserFundList.Actions.UserFundList;
    using SalaryManagerApp.Applications.Budget.Features.UserFundList.Adapters;
    using SalaryManagerApp.Applications.Budget.Features.UserFundList.Infrastructure;
    using SalaryManagerApp.Applications.UserProfile;

    [ApiController]
    [Route(template: "[controller]/{action}")]
    public class UserFundListController
        : SalaryBaseController
    {
        private readonly ILogger<UserFundListController> _logger;

        public UserFundListController(
            ILogger<UserFundListController> logger)
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