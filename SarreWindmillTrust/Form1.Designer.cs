using System.ComponentModel;
using System.Windows.Forms;

namespace SarreWindmillTrust
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.uiLoginGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiLoginButton = new System.Windows.Forms.Button();
            this.uiDonorIDTextBox = new System.Windows.Forms.TextBox();
            this.uiDonationGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uiDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uiDonateButton = new System.Windows.Forms.Button();
            this.uiAmountTextBox = new System.Windows.Forms.TextBox();
            this.uiDonationAmountLabel = new System.Windows.Forms.Label();
            this.uiDonorNameTextBox = new System.Windows.Forms.TextBox();
            this.uiDonorNameLabel = new System.Windows.Forms.Label();
            this.uiDonorDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.uiClearDonorDetailsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiDonorSinceLabel = new System.Windows.Forms.Label();
            this.uiLastDonationLabel = new System.Windows.Forms.Label();
            this.uiTotalDonationsLabel = new System.Windows.Forms.Label();
            this.uiRatingLabel = new System.Windows.Forms.Label();
            this.uiDonorNameHeaderLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiRatingsListBox = new System.Windows.Forms.ListBox();
            this.uiSelectRatingLabel = new System.Windows.Forms.Label();
            this.uiSelectRatingDropdown = new System.Windows.Forms.ComboBox();
            this.uiLoginGroupBox.SuspendLayout();
            this.uiDonationGroupBox.SuspendLayout();
            this.uiDonorDetailsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLoginGroupBox
            // 
            this.uiLoginGroupBox.Controls.Add(this.label1);
            this.uiLoginGroupBox.Controls.Add(this.uiLoginButton);
            this.uiLoginGroupBox.Controls.Add(this.uiDonorIDTextBox);
            this.uiLoginGroupBox.Location = new System.Drawing.Point(12, 12);
            this.uiLoginGroupBox.Name = "uiLoginGroupBox";
            this.uiLoginGroupBox.Size = new System.Drawing.Size(217, 100);
            this.uiLoginGroupBox.TabIndex = 0;
            this.uiLoginGroupBox.TabStop = false;
            this.uiLoginGroupBox.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the donor\'s unique ID.\r\nIf this is a new donor, please leave this \r\n" +
    "box empty to generate a new UID.";
            // 
            // uiLoginButton
            // 
            this.uiLoginButton.Location = new System.Drawing.Point(136, 73);
            this.uiLoginButton.Name = "uiLoginButton";
            this.uiLoginButton.Size = new System.Drawing.Size(75, 23);
            this.uiLoginButton.TabIndex = 1;
            this.uiLoginButton.Text = "Get Donor";
            this.uiLoginButton.UseVisualStyleBackColor = true;
            this.uiLoginButton.Click += new System.EventHandler(this.uiLoginButton_Click);
            // 
            // uiDonorIDTextBox
            // 
            this.uiDonorIDTextBox.Location = new System.Drawing.Point(11, 74);
            this.uiDonorIDTextBox.Name = "uiDonorIDTextBox";
            this.uiDonorIDTextBox.Size = new System.Drawing.Size(119, 20);
            this.uiDonorIDTextBox.TabIndex = 0;
            this.uiDonorIDTextBox.TextChanged += new System.EventHandler(this.uiDonorIDTextBox_TextChanged);
            this.uiDonorIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiDonorIDTextBox_KeyDown);
            // 
            // uiDonationGroupBox
            // 
            this.uiDonationGroupBox.Controls.Add(this.label7);
            this.uiDonationGroupBox.Controls.Add(this.uiDatePicker);
            this.uiDonationGroupBox.Controls.Add(this.uiDonateButton);
            this.uiDonationGroupBox.Controls.Add(this.uiAmountTextBox);
            this.uiDonationGroupBox.Controls.Add(this.uiDonationAmountLabel);
            this.uiDonationGroupBox.Controls.Add(this.uiDonorNameTextBox);
            this.uiDonationGroupBox.Controls.Add(this.uiDonorNameLabel);
            this.uiDonationGroupBox.Location = new System.Drawing.Point(12, 118);
            this.uiDonationGroupBox.Name = "uiDonationGroupBox";
            this.uiDonationGroupBox.Size = new System.Drawing.Size(217, 179);
            this.uiDonationGroupBox.TabIndex = 1;
            this.uiDonationGroupBox.TabStop = false;
            this.uiDonationGroupBox.Text = "Donation Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date of Donation";
            // 
            // uiDatePicker
            // 
            this.uiDatePicker.Location = new System.Drawing.Point(11, 123);
            this.uiDatePicker.MaxDate = new System.DateTime(2018, 11, 14, 0, 0, 0, 0);
            this.uiDatePicker.Name = "uiDatePicker";
            this.uiDatePicker.Size = new System.Drawing.Size(197, 20);
            this.uiDatePicker.TabIndex = 2;
            this.uiDatePicker.Value = new System.DateTime(2018, 11, 14, 0, 0, 0, 0);
            this.uiDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiDatePicker_KeyDown);
            // 
            // uiDonateButton
            // 
            this.uiDonateButton.Location = new System.Drawing.Point(11, 150);
            this.uiDonateButton.Name = "uiDonateButton";
            this.uiDonateButton.Size = new System.Drawing.Size(200, 23);
            this.uiDonateButton.TabIndex = 3;
            this.uiDonateButton.Text = "Make Donation";
            this.uiDonateButton.UseVisualStyleBackColor = true;
            this.uiDonateButton.Click += new System.EventHandler(this.uiDonateButton_Click);
            // 
            // uiAmountTextBox
            // 
            this.uiAmountTextBox.Location = new System.Drawing.Point(11, 80);
            this.uiAmountTextBox.Name = "uiAmountTextBox";
            this.uiAmountTextBox.Size = new System.Drawing.Size(197, 20);
            this.uiAmountTextBox.TabIndex = 1;
            this.uiAmountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiAmountTextBox_KeyDown);
            // 
            // uiDonationAmountLabel
            // 
            this.uiDonationAmountLabel.AutoSize = true;
            this.uiDonationAmountLabel.Location = new System.Drawing.Point(5, 64);
            this.uiDonationAmountLabel.Name = "uiDonationAmountLabel";
            this.uiDonationAmountLabel.Size = new System.Drawing.Size(43, 13);
            this.uiDonationAmountLabel.TabIndex = 6;
            this.uiDonationAmountLabel.Text = "Amount";
            // 
            // uiDonorNameTextBox
            // 
            this.uiDonorNameTextBox.Location = new System.Drawing.Point(11, 37);
            this.uiDonorNameTextBox.Name = "uiDonorNameTextBox";
            this.uiDonorNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.uiDonorNameTextBox.TabIndex = 0;
            this.uiDonorNameTextBox.TextChanged += new System.EventHandler(this.uiDonorNameTextBox_TextChanged);
            // 
            // uiDonorNameLabel
            // 
            this.uiDonorNameLabel.AutoSize = true;
            this.uiDonorNameLabel.Location = new System.Drawing.Point(5, 21);
            this.uiDonorNameLabel.Name = "uiDonorNameLabel";
            this.uiDonorNameLabel.Size = new System.Drawing.Size(67, 13);
            this.uiDonorNameLabel.TabIndex = 0;
            this.uiDonorNameLabel.Text = "Donor Name";
            // 
            // uiDonorDetailsGroupBox
            // 
            this.uiDonorDetailsGroupBox.Controls.Add(this.uiClearDonorDetailsButton);
            this.uiDonorDetailsGroupBox.Controls.Add(this.label6);
            this.uiDonorDetailsGroupBox.Controls.Add(this.label5);
            this.uiDonorDetailsGroupBox.Controls.Add(this.label4);
            this.uiDonorDetailsGroupBox.Controls.Add(this.label3);
            this.uiDonorDetailsGroupBox.Controls.Add(this.label2);
            this.uiDonorDetailsGroupBox.Controls.Add(this.uiDonorSinceLabel);
            this.uiDonorDetailsGroupBox.Controls.Add(this.uiLastDonationLabel);
            this.uiDonorDetailsGroupBox.Controls.Add(this.uiTotalDonationsLabel);
            this.uiDonorDetailsGroupBox.Controls.Add(this.uiRatingLabel);
            this.uiDonorDetailsGroupBox.Controls.Add(this.uiDonorNameHeaderLabel);
            this.uiDonorDetailsGroupBox.Location = new System.Drawing.Point(235, 13);
            this.uiDonorDetailsGroupBox.Name = "uiDonorDetailsGroupBox";
            this.uiDonorDetailsGroupBox.Size = new System.Drawing.Size(354, 284);
            this.uiDonorDetailsGroupBox.TabIndex = 2;
            this.uiDonorDetailsGroupBox.TabStop = false;
            this.uiDonorDetailsGroupBox.Text = "Donor Details";
            // 
            // uiClearDonorDetailsButton
            // 
            this.uiClearDonorDetailsButton.Location = new System.Drawing.Point(273, 255);
            this.uiClearDonorDetailsButton.Name = "uiClearDonorDetailsButton";
            this.uiClearDonorDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.uiClearDonorDetailsButton.TabIndex = 4;
            this.uiClearDonorDetailsButton.Text = "Clear";
            this.uiClearDonorDetailsButton.UseVisualStyleBackColor = true;
            this.uiClearDonorDetailsButton.Click += new System.EventHandler(this.uiClearDonorDetailsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rating:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Donor Since:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Donation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Donations:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // uiDonorSinceLabel
            // 
            this.uiDonorSinceLabel.AutoSize = true;
            this.uiDonorSinceLabel.Location = new System.Drawing.Point(107, 171);
            this.uiDonorSinceLabel.Name = "uiDonorSinceLabel";
            this.uiDonorSinceLabel.Size = new System.Drawing.Size(0, 13);
            this.uiDonorSinceLabel.TabIndex = 4;
            // 
            // uiLastDonationLabel
            // 
            this.uiLastDonationLabel.AutoSize = true;
            this.uiLastDonationLabel.Location = new System.Drawing.Point(107, 124);
            this.uiLastDonationLabel.Name = "uiLastDonationLabel";
            this.uiLastDonationLabel.Size = new System.Drawing.Size(0, 13);
            this.uiLastDonationLabel.TabIndex = 2;
            // 
            // uiTotalDonationsLabel
            // 
            this.uiTotalDonationsLabel.AutoSize = true;
            this.uiTotalDonationsLabel.Location = new System.Drawing.Point(107, 77);
            this.uiTotalDonationsLabel.Name = "uiTotalDonationsLabel";
            this.uiTotalDonationsLabel.Size = new System.Drawing.Size(0, 13);
            this.uiTotalDonationsLabel.TabIndex = 1;
            // 
            // uiRatingLabel
            // 
            this.uiRatingLabel.AutoSize = true;
            this.uiRatingLabel.Location = new System.Drawing.Point(107, 218);
            this.uiRatingLabel.Name = "uiRatingLabel";
            this.uiRatingLabel.Size = new System.Drawing.Size(0, 13);
            this.uiRatingLabel.TabIndex = 0;
            // 
            // uiDonorNameHeaderLabel
            // 
            this.uiDonorNameHeaderLabel.AutoSize = true;
            this.uiDonorNameHeaderLabel.Location = new System.Drawing.Point(107, 35);
            this.uiDonorNameHeaderLabel.Name = "uiDonorNameHeaderLabel";
            this.uiDonorNameHeaderLabel.Size = new System.Drawing.Size(0, 13);
            this.uiDonorNameHeaderLabel.TabIndex = 0;
            this.uiDonorNameHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiRatingsListBox);
            this.groupBox1.Controls.Add(this.uiSelectRatingLabel);
            this.groupBox1.Controls.Add(this.uiSelectRatingDropdown);
            this.groupBox1.Location = new System.Drawing.Point(13, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Donors by Rating";
            // 
            // uiRatingsListBox
            // 
            this.uiRatingsListBox.FormattingEnabled = true;
            this.uiRatingsListBox.Location = new System.Drawing.Point(222, 20);
            this.uiRatingsListBox.Name = "uiRatingsListBox";
            this.uiRatingsListBox.Size = new System.Drawing.Size(350, 69);
            this.uiRatingsListBox.TabIndex = 2;
            // 
            // uiSelectRatingLabel
            // 
            this.uiSelectRatingLabel.AutoSize = true;
            this.uiSelectRatingLabel.Location = new System.Drawing.Point(4, 31);
            this.uiSelectRatingLabel.Name = "uiSelectRatingLabel";
            this.uiSelectRatingLabel.Size = new System.Drawing.Size(82, 13);
            this.uiSelectRatingLabel.TabIndex = 1;
            this.uiSelectRatingLabel.Text = "Minimum Rating";
            // 
            // uiSelectRatingDropdown
            // 
            this.uiSelectRatingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiSelectRatingDropdown.FormattingEnabled = true;
            this.uiSelectRatingDropdown.Location = new System.Drawing.Point(7, 47);
            this.uiSelectRatingDropdown.Name = "uiSelectRatingDropdown";
            this.uiSelectRatingDropdown.Size = new System.Drawing.Size(200, 21);
            this.uiSelectRatingDropdown.TabIndex = 0;
            this.uiSelectRatingDropdown.SelectedIndexChanged += new System.EventHandler(this.uiSelectRatingDropdown_SelectedIndexChanged);
            // 
            // ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiDonorDetailsGroupBox);
            this.Controls.Add(this.uiDonationGroupBox);
            this.Controls.Add(this.uiLoginGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Sarre Windmill Trust - Donation Tracking System";
            this.uiLoginGroupBox.ResumeLayout(false);
            this.uiLoginGroupBox.PerformLayout();
            this.uiDonationGroupBox.ResumeLayout(false);
            this.uiDonationGroupBox.PerformLayout();
            this.uiDonorDetailsGroupBox.ResumeLayout(false);
            this.uiDonorDetailsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox uiLoginGroupBox;
        private Button uiLoginButton;
        private TextBox uiDonorIDTextBox;
        private GroupBox uiDonationGroupBox;
        private Label uiDonorNameLabel;
        private GroupBox uiDonorDetailsGroupBox;
        private TextBox uiDonorNameTextBox;
        private TextBox uiAmountTextBox;
        private Label uiDonationAmountLabel;
        private Button uiDonateButton;
        private Label uiLastDonationLabel;
        private Label uiTotalDonationsLabel;
        private Label uiRatingLabel;
        private Label uiDonorSinceLabel;
        private GroupBox groupBox1;
        private Label uiSelectRatingLabel;
        private ComboBox uiSelectRatingDropdown;
        private ListBox uiRatingsListBox;
        private Label uiDonorNameHeaderLabel;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button uiClearDonorDetailsButton;
        private DateTimePicker uiDatePicker;
        private Label label7;
    }
}

