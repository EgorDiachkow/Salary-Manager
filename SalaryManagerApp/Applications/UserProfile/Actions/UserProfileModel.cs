namespace SalaryManagerApp.Applications.UserProfile.Actions
{
    public class UserProfileActionModel
    {
        public UserProfileActionModel(
            string userEmail,
            string userName,
            string userId,
            long userBalance,
            long totalIncome,
            long totalExpend,
            long totalExpendLimit)
        {
            this.UserEmail = userEmail;
            this.UserName = userName;
            this.userId = userId;
            this.UserBalance = userBalance;
            this.TotalIncome = totalIncome;
            this.TotalExpend = totalExpend;
            this.TotalExpendLimit = totalExpendLimit;
        }

        public string userId { get; }

        public string UserEmail { get; }

        public string UserName { get; }

        public long UserBalance { get; }

        public long TotalIncome { get; }

        public long TotalExpend { get; }

        public long TotalExpendLimit { get; }
    }
}
