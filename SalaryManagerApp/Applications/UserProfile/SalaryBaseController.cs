namespace SalaryManagerApp.Applications.UserProfile
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using SalaryManagerApp.Applications.UserProfile.Actions;
    using SalaryManagerApp.Applications.UserProfile.Infrastructure;

    public abstract class SalaryBaseController
        : Controller
    {
        protected UserProfileActionModel UserProfile { get; private set; }

        public override void OnActionExecuting(
            ActionExecutingContext context)
        {
            this.UserProfile = new UserProfileActionModelQueryHandler()
                .Handle(
                    query: new UserProfileActionModelQuery(
                        userId: "UserIdFromRoute"));

            base.OnActionExecuting(
                context: context);
        }
    }
}