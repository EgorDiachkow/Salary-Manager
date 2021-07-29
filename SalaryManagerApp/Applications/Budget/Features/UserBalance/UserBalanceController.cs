namespace SalaryManagerApp.Applications.Budget.Features.UserBalance
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
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
        public void AddAssetCategory()
        {

        }

        [HttpGet]
        public void AddCreditcardCategory()
        {

        }

        [HttpGet]
        public void AddObligationCategory()
        {

        }

        [HttpGet]
        public void AddSavingCategory()
        {

        }
    }
}
