namespace CurrencyConverter
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
            toCurrency = new ComboBox();
            fromCurrency = new ComboBox();
            textAmount = new TextBox();
            convertButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            labelResult = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toCurrency
            // 
            toCurrency.FormattingEnabled = true;
            toCurrency.Items.AddRange(new object[] { "IDR", "USD", "EUR", "GBP", "JPY" });
            toCurrency.Location = new Point(93, 256);
            toCurrency.Name = "toCurrency";
            toCurrency.Size = new Size(120, 23);
            toCurrency.TabIndex = 0;
            // 
            // fromCurrency
            // 
            fromCurrency.FormattingEnabled = true;
            fromCurrency.Items.AddRange(new object[] { "IDR", "USD", "EUR", "GBP", "JPY" });
            fromCurrency.Location = new Point(94, 138);
            fromCurrency.Name = "fromCurrency";
            fromCurrency.Size = new Size(120, 23);
            fromCurrency.TabIndex = 1;
            // 
            // textAmount
            // 
            textAmount.Location = new Point(248, 138);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(260, 23);
            textAmount.TabIndex = 2;
            textAmount.Text = "0";
            // 
            // convertButton
            // 
            convertButton.BackColor = Color.DodgerBlue;
            convertButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            convertButton.Location = new Point(93, 309);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(193, 37);
            convertButton.TabIndex = 4;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = false;
            convertButton.Click += convertButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Money_Converter;
            panel1.Location = new Point(93, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 73);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(196, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(60, 60);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Convert_Logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(248, 259);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(230, 15);
            labelResult.TabIndex = 8;
            labelResult.Text = "Converted Amount Will Be Displayed Here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Rectangle_6;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(convertButton);
            Controls.Add(textAmount);
            Controls.Add(fromCurrency);
            Controls.Add(toCurrency);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox toCurrency;
        private ComboBox fromCurrency;
        private TextBox textAmount;
        private Button convertButton;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label labelResult;
    }
}