using System;
using System.Collections.Generic;

namespace SarreWindmillTrust
{
    public class Rating
    {
        public string Rank { get; private set; }
        public static readonly object[] Rankings = { "Bronze", "Silver", "Gold", "Diamond", "Platinum" };

        public Rating()
        {
            Rank = (string)Rankings[0];
        }

        public void CalculateRating(List<Donation> donations)
        {
            uint currentRating = 1;
            decimal totalDonations = 0;
            Donation lastDonation = null;
            bool firstDonation = true;
            foreach (Donation donation in donations)
            {
                totalDonations += donation.Amount;

                if (firstDonation)
                {
                    DateTime earlyDonorDate = new DateTime(2010, 01, 01);
                    if (donation.Date < earlyDonorDate)
                    {
                        currentRating += 2;
                    }

                    firstDonation = false;
                }

                else
                {
                    if (donation.Date.AddYears(-1) < lastDonation.Date)
                    {
                        if (donation.Amount > 25M)
                        {
                            currentRating += 1;
                        }
                        if (donation.Amount > 100M)
                        {
                            currentRating += 1;
                        }
                    }
                }
                lastDonation = donation;
            }

            if (totalDonations > 500M)
            {
                currentRating += 5;
            }

            if (totalDonations > 1500M)
            {
                decimal total = (totalDonations - 1500M) / 500M;
                currentRating += (uint)total;
            }

            if (currentRating > 5)  Rank = (string)Rankings[1];
            if (currentRating > 10) Rank = (string)Rankings[2];
            if (currentRating > 25) Rank = (string)Rankings[3];
            if (currentRating > 50) Rank = (string)Rankings[4];
        }

    }
}
