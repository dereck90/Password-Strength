using System.Text.RegularExpressions;

namespace Password_Strength
{
    public partial class Checker : Form
    {
        public Checker()
        {
            InitializeComponent();
        }
        // This method is called whenever the text in the tbPassword TextBox changes.
        //
        // NOTE: this used to track strength incrementally (barValue++/-- as the user
        // typed), which meant a single edit that changed the password by more than one
        // character at once (paste, select-and-delete, cut) could only update ONE
        // requirement per keystroke via an if/else-if chain, leaving the meter and the
        // hint labels out of sync with the actual password for several keystrokes.
        // Recomputing every requirement from scratch on every change removes that whole
        // class of bug - it's always correct for whatever the textbox currently contains,
        // regardless of how it got there.
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            string password = tbPassword.Text;

            // No whitespace allowed - strip it immediately and warn once.
            if (password.Any(char.IsWhiteSpace))
            {
                tbPassword.Text = string.Empty;
                MessageBox.Show("No whitespaces allowed in the password");
                return; // TextChanged will fire again for the now-empty textbox
            }

            bool hasDigit = password.Any(char.IsDigit);
            bool hasLower = password.Any(char.IsLower);
            bool hasUpper = password.Any(char.IsUpper);
            bool hasSymbol = Regex.IsMatch(password, "[^a-zA-Z0-9]");
            bool longEnough = password.Length > 11;

            lblNoNumbers.Visible = !hasDigit;
            lblNoLower.Visible = !hasLower;
            lblNoUpper.Visible = !hasUpper;
            lblNoSymbols.Visible = !hasSymbol;
            lblPasswordLength.Visible = !longEnough;

            int barValue = 0;
            if (hasDigit) barValue++;
            if (hasLower) barValue++;
            if (hasUpper) barValue++;
            if (hasSymbol) barValue++;
            if (longEnough) barValue++;

            if (string.IsNullOrEmpty(password))
            {
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