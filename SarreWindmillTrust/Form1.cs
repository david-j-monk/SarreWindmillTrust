using System;
using System.Threading;
using System.Windows.Forms;

namespace SarreWindmillTrust
{
    public partial class UI : Form
    {
        private readonly CharitySystem charitySystem = new CharitySystem();
        public const string NewDonor = "newDonor";
        private string uID = "";
        private string name = "";
        private decimal amount;
        private DateTime date = DateTime.Today.Date;

        public UI()
        {
            InitializeComponent();
            uiSelectRatingDropdown.Items.AddRange(Rating.Rankings);
            uiDatePicker.MaxDate = date;
            uiDatePicker.Value = date;
            uiSelectRatingDropdown.SelectedIndex = 0;
            DisplayRankingResults();
        }


        #region Event Handlers

        private void uiLoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void uiDonateButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInputs()) ProcessDonation();
        }

        private void uiClearDonorDetailsButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            ClearUIDonorDetails();
        }

        private void uiDonorIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uiDonorIDTextBox.Text.Length > 0)
            {
                ClearUIDonorDetails();
            }
        }

        private void uiDonorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            uiDonorNameTextBox.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(uiDonorNameTextBox.Text);
            uiDonorNameTextBox.Select(uiDonorNameTextBox.TextLength, 0);
            if (uiDonorNameTextBox.Text.Length > 0)
            {
                ClearUIDonorDetails();
            }
        }

        private void uiDonorIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            Login();
            e.SuppressKeyPress = true;
        }

        private void uiAmountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (ValidateUserInputs()) ProcessDonation();
            e.SuppressKeyPress = true;
        }

        private void uiDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (ValidateUserInputs()) ProcessDonation();
            e.SuppressKeyPress = true;
        }

        private void uiSelectRatingDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRankingResults();
        }

        #endregion


        #region Methods

        private void Login()
        {
            string id = uiDonorIDTextBox.Text;
            if (charitySystem.TryToLoadDonor(id))
            {
                uiDonorNameTextBox.Text = charitySystem.CurrentDonor.Name;
                UpdateUIWithDonorDetails();
                uiAmountTextBox.Select();
            }
            else
            {
                ShowToolTip(uiDonorIDTextBox, "Unique ID not found");
                ClearTextBoxes();
                uiDonorIDTextBox.Select();
            }
        }

        private void ProcessDonation()
        {
            string textToShowOnMessageBox = charitySystem.CurrentDonor == null
                ? $"Add {name} as a new donor and \nrecord {amount:C} as their first donation"
                : $"Register donation of {amount:C} from {name}? ";

            DialogResult dialogResult = MessageBox.Show(textToShowOnMessageBox,
                "Confirm Donation", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;

            charitySystem.CreateNewDonor(uID, name);
            charitySystem.AddDonation(amount, date);
            UpdateUIWithDonorDetails();
            charitySystem.ClearCurrentDonor();
            ClearTextBoxes();
            uiDonorIDTextBox.Select();
        }

        private bool CheckIDValidity(string inputUID)
        {
            bool success = true;
            if (inputUID == "")
            {
                uID = NewDonor;
                charitySystem.ClearCurrentDonor();
            }
            else if (!charitySystem.HasDonorBeenLoaded() && !charitySystem.TryToLoadDonor(inputUID))
            {

                ShowToolTip(uiDonorIDTextBox, "Unique ID not found");
                ClearTextBoxes();
                success = false;
            }
            else
            {
                uID = inputUID;
            }

            return success;
        }

        private bool CheckNameValidity(string inputName)
        {
            bool success = true;
            const int minLength = 3;
            const int maxLength = 25;
            if (inputName == "")
            {
                ShowToolTip(uiDonorNameTextBox, "Please enter the donor's name");
                uiDonorNameTextBox.Select();
                success = false;

            }
            else if (inputName.Length < minLength)
            {
                ShowToolTip(uiDonorNameTextBox, $"Min {minLength} characters");
                success = false;
            }
            else if (inputName.Length > maxLength)
            {
                ShowToolTip(uiDonorNameTextBox, $"Max {maxLength} characters");
                success = false;
            }
            else
            {
                name = inputName;
            }

            return success;
        }

        private bool CheckAmountValidity(string inputAmount)
        {
            amount = 0;
            decimal.TryParse(inputAmount, out decimal amountDecimal);
            bool success = true;
            if (inputAmount == "")
            {
                ShowToolTip(uiAmountTextBox, "Please enter a donation amount");
                uiAmountTextBox.Select();
                success = false;
            }

            else if (!decimal.TryParse(string.Format($"{amountDecimal:0.##}"), out amount) || amount < .01M)
            {
                ShowToolTip(uiAmountTextBox, "Please enter a valid donation amount");
                uiAmountTextBox.Clear();
                uiAmountTextBox.Select();
                success = false;
            }
            if (amount > 1000000000)
            {
                ShowToolTip(uiAmountTextBox, "Please enter a smaller donation amount");
                uiAmountTextBox.Clear();
                uiAmountTextBox.Select();
                success = false;
            }
            return success;
        }

        private bool CheckForMismatch(string tempUID, string tempName)
        {
            bool success = true;
            if (!charitySystem.DoesIDMatch(tempUID, tempName))
            {
                MessageBox.Show("Name and ID mismatch.\nPlease try again", "Error");
                charitySystem.ClearCurrentDonor();
                ClearTextBoxes();
                uiDonorIDTextBox.Select();
                success = false;
            }
            return success;
        }

        private bool ValidateUserInputs()
        {
            string tempUID = uiDonorIDTextBox.Text;
            string tempName = uiDonorNameTextBox.Text;
            string tempAmount = uiAmountTextBox.Text;
            date = uiDatePicker.Value;
            
            if (!CheckIDValidity(tempUID)) return false;
            if (!CheckNameValidity(tempName)) return false;
            if (!CheckAmountValidity(tempAmount)) return false;
            return CheckForMismatch(tempUID, tempName);
        }

        private void UpdateUIWithDonorDetails()
        {
            uiDonorSinceLabel.Text = string.Format($"{charitySystem.CurrentDonor.DateOfFirstDonation:d}");
            uiDonorNameHeaderLabel.Text = string.Format($"{charitySystem.CurrentDonor.Name} - {charitySystem.CurrentDonor.UID}");
            uiTotalDonationsLabel.Text = string.Format($"{charitySystem.CurrentDonor.TotalAmountGiven:C}");
            uiLastDonationLabel.Text = string.Format($"{charitySystem.CurrentDonor.LastAmountGiven:C}" +
                                                     $" on {charitySystem.CurrentDonor.DateOfLastDonation:d}");
            uiRatingLabel.Text = charitySystem.CurrentDonor.Rating.Rank;
            DisplayRankingResults();
        }

        private void ClearTextBoxes()
        {
            uiDonorNameTextBox.Clear();
            uiDonorIDTextBox.Clear();
            uiAmountTextBox.Clear();
            uiDatePicker.Value = DateTime.Today;
        }

        private void ClearUIDonorDetails()
        {
            uiTotalDonationsLabel.Text = "";
            uiDonorNameHeaderLabel.Text = "";
            uiDonorSinceLabel.Text = "";
            uiLastDonationLabel.Text = "";
            uiRatingLabel.Text = "";
        }

        private static void ShowToolTip(IWin32Window textBox, string textToDisplay)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show(textToDisplay, textBox, 65, -23, 2500);
        }

        private void DisplayRankingResults()
        {
            uiRatingsListBox.Items.Clear();
            foreach (string chosenRank in charitySystem.CreateListOfChosenRanks(uiSelectRatingDropdown.SelectedIndex))
            {
                uiRatingsListBox.Items.Add(chosenRank);
            }
        }
        #endregion
    }
}
