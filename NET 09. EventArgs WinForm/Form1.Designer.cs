namespace NET_09._EventArgs_WinForm
{
    partial class Form1
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
            firstNumber = new TextBox();
            secondNumber = new TextBox();
            label1 = new Label();
            resultLabel = new Label();
            addButton = new Button();
            subtractButton = new Button();
            multipleButton = new Button();
            divideButton = new Button();
            SuspendLayout();
            // 
            // firstNumber
            // 
            firstNumber.Location = new Point(43, 59);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(100, 23);
            firstNumber.TabIndex = 0;
            // 
            // secondNumber
            // 
            secondNumber.Location = new Point(179, 59);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(100, 23);
            secondNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Result:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(161, 31);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(13, 15);
            resultLabel.TabIndex = 1;
            resultLabel.Text = "0";
            // 
            // addButton
            // 
            addButton.Location = new Point(124, 109);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 2;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += Caluclator;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(124, 138);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(75, 23);
            subtractButton.TabIndex = 2;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            // 
            // multipleButton
            // 
            multipleButton.Location = new Point(124, 167);
            multipleButton.Name = "multipleButton";
            multipleButton.Size = new Size(75, 23);
            multipleButton.TabIndex = 2;
            multipleButton.Text = "*";
            multipleButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(124, 196);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(75, 23);
            divideButton.TabIndex = 2;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 255);
            Controls.Add(divideButton);
            Controls.Add(multipleButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(resultLabel);
            Controls.Add(label1);
            Controls.Add(secondNumber);
            Controls.Add(firstNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNumber;
        private TextBox secondNumber;
        private Label label1;
        private Label resultLabel;
        private Button addButton;
        private Button subtractButton;
        private Button multipleButton;
        private Button divideButton;
    }
}
