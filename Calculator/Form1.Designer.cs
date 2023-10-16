namespace Calculator
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn_1 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(439, 77);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Yellow;
            btn7.BackgroundImageLayout = ImageLayout.Center;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 108);
            btn7.Name = "btn7";
            btn7.Size = new Size(71, 42);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += button_7;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Yellow;
            btn8.BackgroundImageLayout = ImageLayout.Center;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(106, 108);
            btn8.Name = "btn8";
            btn8.Size = new Size(71, 42);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += button_8;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Yellow;
            btn9.BackgroundImageLayout = ImageLayout.Center;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(204, 108);
            btn9.Name = "btn9";
            btn9.Size = new Size(71, 42);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += buttton_9;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Yellow;
            btn6.BackgroundImageLayout = ImageLayout.Center;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(204, 172);
            btn6.Name = "btn6";
            btn6.Size = new Size(71, 42);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += button_6;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Yellow;
            btn5.BackgroundImageLayout = ImageLayout.Center;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(106, 172);
            btn5.Name = "btn5";
            btn5.Size = new Size(71, 42);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += button_5;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Yellow;
            btn4.BackgroundImageLayout = ImageLayout.Center;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 172);
            btn4.Name = "btn4";
            btn4.Size = new Size(71, 42);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += button_4;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Yellow;
            btn3.BackgroundImageLayout = ImageLayout.Center;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(204, 242);
            btn3.Name = "btn3";
            btn3.Size = new Size(71, 42);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Yellow;
            btn2.BackgroundImageLayout = ImageLayout.Center;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(106, 242);
            btn2.Name = "btn2";
            btn2.Size = new Size(71, 42);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.Yellow;
            btn_1.BackgroundImageLayout = ImageLayout.Center;
            btn_1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.Location = new Point(12, 242);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(71, 42);
            btn_1.TabIndex = 7;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(463, 430);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn_1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button button1;
        private Button button2;
        private Button btn_1;
        private Button btn2;
        private Button btn3;
    }
}