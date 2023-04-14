namespace Password_Strength
{
    partial class Checker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checker));
            lblPassword = new Label();
            tbPassword = new TextBox();
            grpStrength = new GroupBox();
            lblStrengthMeter = new Label();
            flpStrength = new FlowLayoutPanel();
            lblNoNumbers = new Label();
            lblNoLower = new Label();
            lblNoUpper = new Label();
            lblNoSymbols = new Label();
            lblPasswordLength = new Label();
            prgrbrStrength = new ProgressBar();
            grpStrength.SuspendLayout();
            flpStrength.SuspendLayout();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 18);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Enter your Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(132, 15);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(175, 23);
            tbPassword.TabIndex = 1;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // grpStrength
            // 
            grpStrength.Controls.Add(lblStrengthMeter);
            grpStrength.Controls.Add(flpStrength);
            grpStrength.Controls.Add(prgrbrStrength);
            grpStrength.Location = new Point(4, 50);
            grpStrength.Name = "grpStrength";
            grpStrength.Size = new Size(316, 204);
            grpStrength.TabIndex = 2;
            grpStrength.TabStop = false;
            grpStrength.Text = "Strength Meter";
            // 
            // lblStrengthMeter
            // 
            lblStrengthMeter.AutoSize = true;
            lblStrengthMeter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStrengthMeter.Location = new Point(98, 172);
            lblStrengthMeter.Name = "lblStrengthMeter";
            lblStrengthMeter.Size = new Size(130, 20);
            lblStrengthMeter.TabIndex = 2;
            lblStrengthMeter.Text = "Password Strength";
            // 
            // flpStrength
            // 
            flpStrength.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpStrength.Controls.Add(lblNoNumbers);
            flpStrength.Controls.Add(lblNoLower);
            flpStrength.Controls.Add(lblNoUpper);
            flpStrength.Controls.Add(lblNoSymbols);
            flpStrength.Controls.Add(lblPasswordLength);
            flpStrength.FlowDirection = FlowDirection.TopDown;
            flpStrength.Location = new Point(6, 22);
            flpStrength.Name = "flpStrength";
            flpStrength.Padding = new Padding(9);
            flpStrength.Size = new Size(304, 118);
            flpStrength.TabIndex = 0;
            // 
            // lblNoNumbers
            // 
            lblNoNumbers.AutoSize = true;
            lblNoNumbers.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoNumbers.Location = new Point(12, 9);
            lblNoNumbers.Name = "lblNoNumbers";
            lblNoNumbers.Size = new Size(176, 20);
            lblNoNumbers.TabIndex = 0;
            lblNoNumbers.Text = "No numbers on Password";
            // 
            // lblNoLower
            // 
            lblNoLower.AutoSize = true;
            lblNoLower.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoLower.Location = new Point(12, 29);
            lblNoLower.Name = "lblNoLower";
            lblNoLower.Size = new Size(230, 20);
            lblNoLower.TabIndex = 1;
            lblNoLower.Text = "No lowercase letters on Password";
            // 
            // lblNoUpper
            // 
            lblNoUpper.AutoSize = true;
            lblNoUpper.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoUpper.Location = new Point(12, 49);
            lblNoUpper.Name = "lblNoUpper";
            lblNoUpper.Size = new Size(232, 20);
            lblNoUpper.TabIndex = 2;
            lblNoUpper.Text = "No uppercase letters on Password";
            // 
            // lblNoSymbols
            // 
            lblNoSymbols.AutoSize = true;
            lblNoSymbols.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoSymbols.Location = new Point(12, 69);
            lblNoSymbols.Name = "lblNoSymbols";
            lblNoSymbols.Size = new Size(173, 20);
            lblNoSymbols.TabIndex = 3;
            lblNoSymbols.Text = "No symbols on Password";
            // 
            // lblPasswordLength
            // 
            lblPasswordLength.AutoSize = true;
            lblPasswordLength.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPasswordLength.Location = new Point(12, 89);
            lblPasswordLength.Name = "lblPasswordLength";
            lblPasswordLength.Size = new Size(186, 20);
            lblPasswordLength.TabIndex = 4;
            lblPasswordLength.Text = "Has less than 12 characters";
            // 
            // prgrbrStrength
            // 
            prgrbrStrength.Location = new Point(14, 146);
            prgrbrStrength.Maximum = 5;
            prgrbrStrength.Name = "prgrbrStrength";
            prgrbrStrength.Size = new Size(289, 23);
            prgrbrStrength.Step = 1;
            prgrbrStrength.Style = ProgressBarStyle.Continuous;
            prgrbrStrength.TabIndex = 1;
            // 
            // Checker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 258);
            Controls.Add(grpStrength);
            Controls.Add(tbPassword);
            Controls.Add(lblPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Checker";
            Text = "Password Checker";
            grpStrength.ResumeLayout(false);
            grpStrength.PerformLayout();
            flpStrength.ResumeLayout(false);
            flpStrength.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox tbPassword;
        private GroupBox grpStrength;
        private FlowLayoutPanel flpStrength;
        private Label lblNoNumbers;
        private Label lblNoLower;
        private Label lblNoUpper;
        private ProgressBar prgrbrStrength;
        private Label lblNoSymbols;
        private Label lblStrengthMeter;
        private Label lblPasswordLength;
    }
}