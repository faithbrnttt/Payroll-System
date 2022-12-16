﻿namespace Burnett_CourseProject_Part2
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.SSNLabel = new System.Windows.Forms.Label();
            this.HireDateTextBox = new System.Windows.Forms.TextBox();
            this.HireDateLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BenefitsGroupBox = new System.Windows.Forms.GroupBox();
            this.VacationDaysTextBox = new System.Windows.Forms.TextBox();
            this.VacationDaysLabel = new System.Windows.Forms.Label();
            this.LifeInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.LifeInsuranceLabel = new System.Windows.Forms.Label();
            this.HealthInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.HealthInsuranceLabel = new System.Windows.Forms.Label();
            this.EmployeeTypeLabel = new System.Windows.Forms.Label();
            this.HourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.SalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.HourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.HourlyRateLabel = new System.Windows.Forms.Label();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.BenefitsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(56, 43);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(162, 31);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name: ";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(224, 40);
            this.FirstNameTextBox.Multiline = true;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(245, 45);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(224, 125);
            this.LastNameTextBox.Multiline = true;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(245, 43);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(56, 128);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(153, 31);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Location = new System.Drawing.Point(224, 202);
            this.SSNTextBox.Multiline = true;
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(245, 44);
            this.SSNTextBox.TabIndex = 2;
            // 
            // SSNLabel
            // 
            this.SSNLabel.AutoSize = true;
            this.SSNLabel.Location = new System.Drawing.Point(56, 205);
            this.SSNLabel.Name = "SSNLabel";
            this.SSNLabel.Size = new System.Drawing.Size(78, 31);
            this.SSNLabel.TabIndex = 4;
            this.SSNLabel.Text = "SSN:";
            // 
            // HireDateTextBox
            // 
            this.HireDateTextBox.Location = new System.Drawing.Point(224, 276);
            this.HireDateTextBox.Multiline = true;
            this.HireDateTextBox.Name = "HireDateTextBox";
            this.HireDateTextBox.Size = new System.Drawing.Size(245, 44);
            this.HireDateTextBox.TabIndex = 3;
            // 
            // HireDateLabel
            // 
            this.HireDateLabel.AutoSize = true;
            this.HireDateLabel.Location = new System.Drawing.Point(56, 279);
            this.HireDateLabel.Name = "HireDateLabel";
            this.HireDateLabel.Size = new System.Drawing.Size(137, 31);
            this.HireDateLabel.TabIndex = 6;
            this.HireDateLabel.Text = "Hire Date:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(124, 632);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(187, 65);
            this.SubmitButton.TabIndex = 17;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(389, 632);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(187, 65);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BenefitsGroupBox
            // 
            this.BenefitsGroupBox.Controls.Add(this.VacationDaysTextBox);
            this.BenefitsGroupBox.Controls.Add(this.VacationDaysLabel);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsuranceTextBox);
            this.BenefitsGroupBox.Controls.Add(this.LifeInsuranceLabel);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsuranceTextBox);
            this.BenefitsGroupBox.Controls.Add(this.HealthInsuranceLabel);
            this.BenefitsGroupBox.Location = new System.Drawing.Point(649, 40);
            this.BenefitsGroupBox.Name = "BenefitsGroupBox";
            this.BenefitsGroupBox.Size = new System.Drawing.Size(595, 280);
            this.BenefitsGroupBox.TabIndex = 4;
            this.BenefitsGroupBox.TabStop = false;
            this.BenefitsGroupBox.Text = "Benefits";
            // 
            // VacationDaysTextBox
            // 
            this.VacationDaysTextBox.Location = new System.Drawing.Point(300, 187);
            this.VacationDaysTextBox.Multiline = true;
            this.VacationDaysTextBox.Name = "VacationDaysTextBox";
            this.VacationDaysTextBox.Size = new System.Drawing.Size(265, 49);
            this.VacationDaysTextBox.TabIndex = 2;
            // 
            // VacationDaysLabel
            // 
            this.VacationDaysLabel.AutoSize = true;
            this.VacationDaysLabel.Location = new System.Drawing.Point(56, 187);
            this.VacationDaysLabel.Name = "VacationDaysLabel";
            this.VacationDaysLabel.Size = new System.Drawing.Size(128, 31);
            this.VacationDaysLabel.TabIndex = 4;
            this.VacationDaysLabel.Text = "Vacation:";
            // 
            // LifeInsuranceTextBox
            // 
            this.LifeInsuranceTextBox.Location = new System.Drawing.Point(300, 123);
            this.LifeInsuranceTextBox.Multiline = true;
            this.LifeInsuranceTextBox.Name = "LifeInsuranceTextBox";
            this.LifeInsuranceTextBox.Size = new System.Drawing.Size(265, 48);
            this.LifeInsuranceTextBox.TabIndex = 1;
            // 
            // LifeInsuranceLabel
            // 
            this.LifeInsuranceLabel.AutoSize = true;
            this.LifeInsuranceLabel.Location = new System.Drawing.Point(56, 123);
            this.LifeInsuranceLabel.Name = "LifeInsuranceLabel";
            this.LifeInsuranceLabel.Size = new System.Drawing.Size(193, 31);
            this.LifeInsuranceLabel.TabIndex = 2;
            this.LifeInsuranceLabel.Text = "Life Insurance:";
            // 
            // HealthInsuranceTextBox
            // 
            this.HealthInsuranceTextBox.Location = new System.Drawing.Point(300, 54);
            this.HealthInsuranceTextBox.Multiline = true;
            this.HealthInsuranceTextBox.Name = "HealthInsuranceTextBox";
            this.HealthInsuranceTextBox.Size = new System.Drawing.Size(265, 46);
            this.HealthInsuranceTextBox.TabIndex = 0;
            // 
            // HealthInsuranceLabel
            // 
            this.HealthInsuranceLabel.AutoSize = true;
            this.HealthInsuranceLabel.Location = new System.Drawing.Point(56, 57);
            this.HealthInsuranceLabel.Name = "HealthInsuranceLabel";
            this.HealthInsuranceLabel.Size = new System.Drawing.Size(228, 31);
            this.HealthInsuranceLabel.TabIndex = 0;
            this.HealthInsuranceLabel.Text = "Health Insurance:";
            // 
            // EmployeeTypeLabel
            // 
            this.EmployeeTypeLabel.AutoSize = true;
            this.EmployeeTypeLabel.Location = new System.Drawing.Point(56, 397);
            this.EmployeeTypeLabel.Name = "EmployeeTypeLabel";
            this.EmployeeTypeLabel.Size = new System.Drawing.Size(210, 31);
            this.EmployeeTypeLabel.TabIndex = 7;
            this.EmployeeTypeLabel.Text = "Employee Type:";
            // 
            // HourlyRadioButton
            // 
            this.HourlyRadioButton.AutoSize = true;
            this.HourlyRadioButton.Location = new System.Drawing.Point(311, 397);
            this.HourlyRadioButton.Name = "HourlyRadioButton";
            this.HourlyRadioButton.Size = new System.Drawing.Size(111, 35);
            this.HourlyRadioButton.TabIndex = 12;
            this.HourlyRadioButton.TabStop = true;
            this.HourlyRadioButton.Text = "Hourly";
            this.HourlyRadioButton.UseVisualStyleBackColor = true;
            this.HourlyRadioButton.CheckedChanged += new System.EventHandler(this.HourlyRadioButton_CheckedChanged);
            // 
            // SalaryRadioButton
            // 
            this.SalaryRadioButton.AutoSize = true;
            this.SalaryRadioButton.Location = new System.Drawing.Point(451, 397);
            this.SalaryRadioButton.Name = "SalaryRadioButton";
            this.SalaryRadioButton.Size = new System.Drawing.Size(109, 35);
            this.SalaryRadioButton.TabIndex = 15;
            this.SalaryRadioButton.TabStop = true;
            this.SalaryRadioButton.Text = "Salary";
            this.SalaryRadioButton.UseVisualStyleBackColor = true;
            this.SalaryRadioButton.CheckedChanged += new System.EventHandler(this.SalaryRadioButton_CheckedChanged);
            // 
            // HourlyRateTextBox
            // 
            this.HourlyRateTextBox.Location = new System.Drawing.Point(319, 474);
            this.HourlyRateTextBox.Multiline = true;
            this.HourlyRateTextBox.Name = "HourlyRateTextBox";
            this.HourlyRateTextBox.Size = new System.Drawing.Size(245, 45);
            this.HourlyRateTextBox.TabIndex = 13;
            this.HourlyRateTextBox.Visible = false;
            // 
            // HourlyRateLabel
            // 
            this.HourlyRateLabel.AutoSize = true;
            this.HourlyRateLabel.Location = new System.Drawing.Point(122, 477);
            this.HourlyRateLabel.Name = "HourlyRateLabel";
            this.HourlyRateLabel.Size = new System.Drawing.Size(166, 31);
            this.HourlyRateLabel.TabIndex = 11;
            this.HourlyRateLabel.Text = "Hourly Rate:";
            this.HourlyRateLabel.Visible = false;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(319, 549);
            this.HoursWorkedTextBox.Multiline = true;
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(245, 45);
            this.HoursWorkedTextBox.TabIndex = 14;
            this.HoursWorkedTextBox.Visible = false;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(118, 552);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(195, 31);
            this.HoursWorkedLabel.TabIndex = 13;
            this.HoursWorkedLabel.Text = "Hours Worked:";
            this.HoursWorkedLabel.Visible = false;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(319, 474);
            this.SalaryTextBox.Multiline = true;
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(245, 45);
            this.SalaryTextBox.TabIndex = 16;
            this.SalaryTextBox.Visible = false;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(122, 474);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(99, 31);
            this.SalaryLabel.TabIndex = 15;
            this.SalaryLabel.Text = "Salary:";
            this.SalaryLabel.Visible = false;
            // 
            // InputForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1277, 846);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.HourlyRateTextBox);
            this.Controls.Add(this.HourlyRateLabel);
            this.Controls.Add(this.SalaryRadioButton);
            this.Controls.Add(this.HourlyRadioButton);
            this.Controls.Add(this.EmployeeTypeLabel);
            this.Controls.Add(this.BenefitsGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HireDateTextBox);
            this.Controls.Add(this.HireDateLabel);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.SSNLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "InputForm";
            this.Text = "Employee Input Form";
            this.BenefitsGroupBox.ResumeLayout(false);
            this.BenefitsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        public System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.Label SSNLabel;
        public System.Windows.Forms.TextBox HireDateTextBox;
        private System.Windows.Forms.Label HireDateLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox BenefitsGroupBox;
        public System.Windows.Forms.TextBox VacationDaysTextBox;
        private System.Windows.Forms.Label VacationDaysLabel;
        public System.Windows.Forms.TextBox LifeInsuranceTextBox;
        private System.Windows.Forms.Label LifeInsuranceLabel;
        public System.Windows.Forms.TextBox HealthInsuranceTextBox;
        private System.Windows.Forms.Label HealthInsuranceLabel;
        public System.Windows.Forms.Button SubmitButton;
        public System.Windows.Forms.TextBox HourlyRateTextBox;
        public System.Windows.Forms.TextBox HoursWorkedTextBox;
        public System.Windows.Forms.TextBox SalaryTextBox;
        public System.Windows.Forms.Label EmployeeTypeLabel;
        public System.Windows.Forms.RadioButton HourlyRadioButton;
        public System.Windows.Forms.RadioButton SalaryRadioButton;
        public System.Windows.Forms.Label HourlyRateLabel;
        public System.Windows.Forms.Label HoursWorkedLabel;
        public System.Windows.Forms.Label SalaryLabel;
    }
}