using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burnett_CourseProject_Part2
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Regex alpha = new Regex("^[a-zA-z]*$");
            Regex num = new Regex("^[0-9-]*$");
            Regex soc = new Regex("^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$");
            Regex date = new Regex("^(1[0-2]|0[1-9])/(3[01]|[12][0-9]|0[1-9])/[0-9]{4}$");

            if (!alpha.IsMatch(FirstNameTextBox.Text) || string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                MessageBox.Show("Enter a first name using only alpha characters");
            }
            else if (!alpha.IsMatch(LastNameTextBox.Text) || string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("Enter a last name using only alpha characters");
            }
            else if (!soc.IsMatch(SSNTextBox.Text) || string.IsNullOrEmpty(SSNTextBox.Text))
            {
                MessageBox.Show("Enter a valid social in the format(222-22-2222)");
            }
            else if (!date.IsMatch(HireDateTextBox.Text) || string.IsNullOrEmpty(HireDateTextBox.Text))
            {
                MessageBox.Show("Enter a valid date in the format(mm/dd/yyyy)");
            }
            else if (!alpha.IsMatch(HealthInsuranceTextBox.Text) || string.IsNullOrEmpty(HealthInsuranceTextBox.Text))
            {
                MessageBox.Show("Enter a valid healthcare provider");
            }
            else if (!num.IsMatch(LifeInsuranceTextBox.Text) || string.IsNullOrEmpty(LifeInsuranceTextBox.Text))
            {
                MessageBox.Show("Enter a valid insurance amount");
            }
            else if (!num.IsMatch(VacationDaysTextBox.Text) || string.IsNullOrEmpty(VacationDaysTextBox.Text))
            {
                MessageBox.Show("Enter a valid number of vacation days");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Hide();
        }

        private void HourlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HourlyRadioButton.Checked)
            {
                //hide the salary items
                SalaryLabel.Visible = false;
                SalaryTextBox.Visible = false;

                //show the hourly items
                HourlyRateLabel.Visible = true;
                HourlyRateTextBox.Visible = true;
                HoursWorkedLabel.Visible = true;
                HoursWorkedTextBox.Visible = true;
            }
        }

        private void SalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SalaryRadioButton.Checked)
            {
                //hide the hourly items
                SalaryLabel.Visible = true;
                SalaryTextBox.Visible = true;

                //show the salary items
                HourlyRateLabel.Visible = false;
                HourlyRateTextBox.Visible = false;
                HoursWorkedTextBox.Visible = false;
                HoursWorkedLabel.Visible = false;
            }
        }
    }
}
