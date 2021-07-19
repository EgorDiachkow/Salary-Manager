namespace SalaryManagerApp.Applications.MainProfile.Features
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using SalaryManagerApp.Applications.MainProfile.Features.UserProfile.Actions.Profile;
    using SalaryManagerApp.Applications.MainProfile.Features.UserProfile.Infrastructure;

    [ApiController]
    [Route(template: "[controller]")]
    public class UserProfileController
        : Controller
    {
        private readonly ILogger<UserProfileController> _logger;

        public UserProfileController(ILogger<UserProfileController> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public UserProfileActionModel Get()
        {
            var getData = new UserProfileActionModelQueryHandler();

            var data = getData
                .Handle(
                    query: new UserProfileActionModelQuery(
                        userId: 1));

            return data;
        }
    }
}