# Password Strength Checker
This C# code provides a password strength checker with a graphical user interface (GUI)
using Windows Forms. The program uses a progress bar and a label to display the strength
of the password. It checks for the following password requirements:

*No whitespace characters
*At least one digit
*At least one lowercase letter
*At least one uppercase letter
*At least one symbol (not a letter or digit)
*Length of at least 12 characters

The GUI has a textbox where the user can input their password. Whenever the text in the
textbox changes, the code executes the tbPassword_TextChanged method to check the strength 
of the password.

If the password meets the requirements, the program increments the progress bar and changes 
the corresponding label visibility to false. If the password no longer meets the requirements, 
the program decrements the progress bar and changes the corresponding label visibility back to true.

If the password is empty, the program resets the progress bar and all the labels.

Finally, the program displays the strength of the password in a label. If the progress bar 
value is 0-2, it shows "Weak Password". If the progress bar value is 3, it shows "Fair Password".
If the progress bar value is 4-5, it shows "Strong Password".

This code uses the System.Text.RegularExpressions namespace to match symbols in the password.
It also utilizes the System.Windows.Forms namespace to create the GUI.