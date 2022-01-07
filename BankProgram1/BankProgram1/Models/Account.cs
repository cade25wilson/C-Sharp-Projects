namespace bankProgram.Models
{
    public class Account
    {
        public enum accountType
        {
            Savings, Checking
        }

        public int Id { get; set; }
        public int accountOwner { get; set; }
        public accountType Type { get; set; }
        public string accountName { get; set; }
        public decimal beginningBalance { get; set; }
        public decimal balance { get; }

    }
}
