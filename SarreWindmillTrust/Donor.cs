using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SarreWindmillTrust
{
    public class Donor
    {

        public string Name { get; }
        public string UID { get; }
        public Rating Rating { get; }
        public DateTime DateOfFirstDonation { get; private set; }
        public DateTime DateOfLastDonation { get; private set; }
        public decimal TotalAmountGiven { get; private set; }
        public decimal LastAmountGiven { get; private set; }

        private List<Donation> donations;
        private static int currentID = 1;


        public Donor(string name)
        {
            Name = name;
            UID = string.Format($"{name.Substring(0, 3)}{currentID++}").ToLower();
            Rating = new Rating();
            donations = new List<Donation>();
        }

        public bool IsDonorRegistered(string uID)
        {
            return uID.ToLower() == UID;
        }

        public void CalculateRating()
        {
            Rating.CalculateRating(donations);
        }

        public void JoinSameDayDonations()
        {
            for (int i = 0; i < donations.Count - 1; i++)
            {
                if (donations.Last().Date != donations[i].Date) continue;
                DialogResult dialogResult = MessageBox.Show($"There is already a donation registered for this date.\nPress 'Yes' to combine the donations, or press 'No' to cancel.",
                    "Duplicate Date", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    donations[i].IncreaseDonation(donations.Last().Amount);
                }
                donations.RemoveAt(donations.Count - 1);
                return;
            }
        }

        public void SortDonations()
        {
            donations = donations.OrderBy(donation => donation.Date).ToList();
        }

        public void UpdateDonorMembers()
        {
            DateOfFirstDonation = donations.First().Date;
            DateOfLastDonation = donations.Last().Date;
            TotalAmountGiven = 0;
            foreach (Donation donation in donations)
            {
                TotalAmountGiven += donation.Amount;
            }
            LastAmountGiven = donations.Last().Amount;
        }

        public void AddNewDonation(decimal donation, DateTime date)
        {
            donations.Add(new Donation(donation, date));
        }
    }
}