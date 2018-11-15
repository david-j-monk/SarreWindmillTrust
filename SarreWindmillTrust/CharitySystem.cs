using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SarreWindmillTrust
{
    class CharitySystem
    {
        private readonly List<Donor> donors;
        public Donor CurrentDonor { get; private set; }

        public CharitySystem()
        {
            donors = new List<Donor>();
        }

        public void CreateNewDonor(string uID, string name)
        {
            if (uID == UI.NewDonor)
            {
                donors.Add(new Donor(name));
                CurrentDonor = donors.Last();
                MessageBox.Show($"Unique ID created for {CurrentDonor.Name}\n\n" +
                                $">>>>   {CurrentDonor.UID}   <<<<\n\n" +
                                "Please keep it safe.", "New Donor Registered");
            }
        }

        public void AddDonation(decimal donation, DateTime date)
        {
            CurrentDonor.AddNewDonation(donation, date);
            CurrentDonor.SortDonations();
            CurrentDonor.CalculateRating();
            CurrentDonor.UpdateDonorMembers();
        }

        public void ClearCurrentDonor() => CurrentDonor = null;

        public bool TryToLoadDonor(string userInput)
        {
            foreach (Donor donor in donors)
            {
                if (donor.IsDonorRegistered(userInput.ToLower()))
                {
                    CurrentDonor = donor;
                    return true;
                }
            }
            return false;
        }

        public bool DoesIDMatch(string uId, string name)
        {
            bool success = true;
            if (HasDonorBeenLoaded())
            {
                success = uId == CurrentDonor.UID && name == CurrentDonor.Name;
            }

            return success;
        }

        public bool HasDonorBeenLoaded()
        {
            return CurrentDonor != null;
        }

        
        public List<string> CreateListOfChosenRanks(int index)
        {

            List<string> listOfDonorsOfChosenRank = new List<string>();
            foreach (Donor donor in donors)
            {
                for (int i = index; i < Rating.Rankings.Length; i++)
                {
                    if (donor.Rating.Rank == (string)Rating.Rankings[i])
                    {
                        listOfDonorsOfChosenRank.Add($" {donor.Name} - {donor.UID}");
                    }
                }
            }

            return listOfDonorsOfChosenRank;
        }
    }
}
