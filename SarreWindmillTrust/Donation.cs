using System;

namespace SarreWindmillTrust
{
    public class Donation
    {
        public DateTime Date { get; }
        public decimal Amount { get; }

        public Donation(decimal amount, DateTime date)
        {
            Date   = date;
            Amount = amount;
        }
    }
}