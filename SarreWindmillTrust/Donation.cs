using System;

namespace SarreWindmillTrust
{
    public class Donation
    {
        public DateTime Date { get; }
        public decimal Amount { get; private set; }

        public Donation(decimal amount, DateTime date)
        {
            Date   = date;
            Amount = amount;
        }

        public void IncreaseDonation(decimal amount)
        {
            Amount += amount;
        }
    }
}