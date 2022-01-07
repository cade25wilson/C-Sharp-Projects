using System;

namespace bankProgram.Models
{
    public class Transfer
    {
        public enum TranferType
        {
            Deposit, Withdrawl
        }
        public int Id { get; set; }
        public int amount { get; set; }
        public DateTime Date { get; set; }
        public TranferType Type { get; set; }

    }
}
