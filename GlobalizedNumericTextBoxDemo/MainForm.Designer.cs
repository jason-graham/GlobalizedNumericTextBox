namespace GlobalizedNumericTextBoxDemo
{
    partial class MainForm
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.numericTextBox = new System.Windows.Forms.GlobalizedNumericTextBox();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 26);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.numericTextBox;
            this.propertyGrid1.Size = new System.Drawing.Size(534, 346);
            this.propertyGrid1.TabIndex = 3;
            // 
            // numericTextBox
            // 
            this.numericTextBox.CurrencyDecimalDigits = 2;
            this.numericTextBox.CurrencyDecimalSeparator = ".";
            this.numericTextBox.CurrencyGroupSeparator = ",";
            this.numericTextBox.CurrencyGroupSizes = new int[] {
        3};
            this.numericTextBox.CurrencyNegativePattern = 0;
            this.numericTextBox.CurrencyPositivePattern = 0;
            this.numericTextBox.CurrencySymbol = "$";
            this.numericTextBox.CustomFormat = "";
            this.numericTextBox.DisplayFormat = System.Windows.Forms.GlobalizedNumericTextBoxDisplayFormat.Normal;
            this.numericTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox.Location = new System.Drawing.Point(0, 0);
            this.numericTextBox.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBox.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numericTextBox.Name = "numericTextBox";
            this.numericTextBox.NegativeSign = "-";
            this.numericTextBox.NumberDecimalDigits = 2;
            this.numericTextBox.NumberDecimalSeparator = ".";
            this.numericTextBox.NumberGroupSeparator = ",";
            this.numericTextBox.NumberGroupSizes = new int[] {
        3};
            this.numericTextBox.NumberNegativePattern = 1;
            this.numericTextBox.PositiveSign = "+";
            this.numericTextBox.ResetOnEscape = true;
            this.numericTextBox.Size = new System.Drawing.Size(534, 26);
            this.numericTextBox.TabIndex = 0;
            this.numericTextBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 372);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.numericTextBox);
            this.Name = "MainForm";
            this.Text = "GlobalizedNumericTextBoxDemo Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.GlobalizedNumericTextBox numericTextBox;
    }
}

