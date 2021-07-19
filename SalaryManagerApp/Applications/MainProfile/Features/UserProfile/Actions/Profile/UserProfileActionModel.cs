namespace SalaryManagerApp.Applications.MainProfile.Features.UserProfile.Actions.Profile
{
    public class UserProfileActionModel
    {
        public UserProfileActionModel(
            int userId,
            string userEmail,
            string userName,
            long userBalance,
            long totalIncome,
            long totalExpend)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.UserName = userName;
            this.UserBalance = userBalance;
            this.TotalIncome = totalIncome;
            this.TotalExpend = totalExpend;
        }

        public int UserId { get; }

        public string UserEmail { get; }

        public string UserName { get; }

        public long UserBalance { get; }

        public long TotalIncome { get; }

        public long TotalExpend { get; }
    }
}
