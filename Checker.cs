using System.Text.RegularExpressions;

namespace Password_Strength
{
    public partial class Checker : Form
    {
        public Checker()
        {
            InitializeComponent();
        }
        //Variable creation
        int barValue;
        string previousPass = "";
        string password = "";
        // This method is called whenever the text in the tbPassword TextBox changes.
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            // Store the new password in the 'password' variable.
            password = tbPassword.Text;

            // If the new password is longer than the previous password...
            if (password.Length > previousPass.Length)
            {
                // Loop through each character in the new password.
                foreach (char c in password)
                {
                    // If the character is a whitespace character...
                    if (char.IsWhiteSpace(c))
                    {
                        // Clear the password field and show an error message.
                        tbPassword.Text = string.Empty;
                        MessageBox.Show("No whitespaces allowed in the password");
                    }
                    // If the character is a digit and the 'NoNumbers' label is currently visible...
                    if (char.IsDigit(c) && lblNoNumbers.Visible)
                    {
                        // Hide the 'NoNumbers' label and increment the 'barValue' variable.
                        lblNoNumbers.Visible = false;
                        barValue++;
                    }
                    // If the character is a lowercase letter and the 'NoLower' label is currently visible...
                    else if (char.IsLower(c) && lblNoLower.Visible)
                    {
                        // Hide the 'NoLower' label and increment the 'barValue' variable.
                        lblNoLower.Visible = false;
                        barValue++;
                    }
                    // If the character is an uppercase letter and the 'NoUpper' label is currently visible...
                    else if (char.IsUpper(c) && lblNoUpper.Visible)
                    {
                        // Hide the 'NoUpper' label and increment the 'barValue' variable.
                        lblNoUpper.Visible = false;
                        barValue++;
                    }
                    // If the character is a symbol (not a letter or digit) and the 'NoSymbols' label is currently visible...
                    else if (Regex.IsMatch(password, "[^a-zA-Z0-9]+") && lblNoSymbols.Visible)
                    {
                        // Hide the 'NoSymbols' label and increment the 'barValue' variable.
                        lblNoSymbols.Visible = false;
                        barValue++;
                    }
                    // If the password is longer than 11 characters and the 'PasswordLength' label is currently visible...
                    else if (password.Length > 11 && lblPasswordLength.Visible)
                    {
                        // Hide the 'PasswordLength' label and increment the 'barValue' variable.
                        lblPasswordLength.Visible = false;
                        barValue++;
                    }
                }
                // Store the new password as the previous password for the next time this method is called.
                previousPass = password;
            }
            // If the new password is shorter than the previous password...
            else if (password.Length < previousPass.Length)
            {
                // Check which password requirement(s) are no longer met and update the progress bar accordingly.
                if (!password.Any(char.IsDigit) && !lblNoNumbers.Visible)
                {
                    lblNoNumbers.Visible = true;
                    barValue--;
                }
                else if (!password.Any(char.IsLower) && !lblNoLower.Visible)
                {
                    lblNoLower.Visible = true;
                    barValue--;
                }
                else if (!password.Any(char.IsUpper) && !lblNoUpper.Visible)
                {
                    lblNoUpper.Visible = true;
                    barValue--;
                }
                else if (password.Length <= 11 && !lblPasswordLength.Visible)
                {
                    lblPasswordLength.Visible = true;
                    barValue--;
                }
                else if (!Regex.IsMatch(password, "[^a-zA-Z0-9]+") && !lblNoSymbols.Visible)
                {
                    lblNoSymbols.Visible = true;
                    barValue--;
                }
                else
                {

                }
                previousPass = password;
            }
            //If password is empty, then resets all the labels and progressbar
            if (string.IsNullOrEmpty(password))
            {
                // Reset the progress bar and labels
                prgrbrStrength.Value = 0;
                lblNoNumbers.Visible = true;
                lblNoLower.Visible = true;
                lblNoUpper.Visible = true;
                lblNoSymbols.Visible = true;
                lblPasswordLength.Visible = true;
                barValue = 0;
            }
            prgrbrStrength.Value = barValue;

            //If barValue is 0-2, print Weak Password on the label
            if (barValue >= 0 && barValue < 3)
            {
                lblStrengthMeter.Text = "Weak Password";
            }
            //If barValue is 3, print Fair Password on the label
            else if (barValue == 3)
            {
                lblStrengthMeter.Text = "Fair Password";
            }
            //If barValue is 4-5, print Strong Password on the label
            else if (barValue > 3 && barValue <= 5)
            {
                lblStrengthMeter.Text = "Strong Password";
            }
        }
    }
}