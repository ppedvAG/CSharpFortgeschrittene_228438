﻿namespace HalloAsync
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
            progressBar1 = new ProgressBar();
            withoutThreadButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(20, 315);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(379, 46);
            progressBar1.TabIndex = 0;
            // 
            // withoutThreadButton
            // 
            withoutThreadButton.Location = new Point(12, 12);
            withoutThreadButton.Name = "withoutThreadButton";
            withoutThreadButton.Size = new Size(379, 46);
            withoutThreadButton.TabIndex = 1;
            withoutThreadButton.Text = "Ohne Thread";
            withoutThreadButton.UseVisualStyleBackColor = true;
            withoutThreadButton.Click += withoutThreadButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 76);
            button1.Name = "button1";
            button1.Size = new Size(379, 46);
            button1.TabIndex = 2;
            button1.Text = "Start Task (dispatcher)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(20, 141);
            button2.Name = "button2";
            button2.Size = new Size(379, 46);
            button2.TabIndex = 3;
            button2.Text = "Start Task (TaskScheduler)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(20, 377);
            button3.Name = "button3";
            button3.Size = new Size(379, 46);
            button3.TabIndex = 4;
            button3.Text = "Abbrechen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(18, 202);
            button4.Name = "button4";
            button4.Size = new Size(379, 46);
            button4.TabIndex = 5;
            button4.Text = "Start Task (Async/Await)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(20, 254);
            button5.Name = "button5";
            button5.Size = new Size(379, 46);
            button5.TabIndex = 6;
            button5.Text = "SlowCalc";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(18, 561);
            button6.Name = "button6";
            button6.Size = new Size(379, 46);
            button6.TabIndex = 7;
            button6.Text = "Count Customers";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 505);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 8;
            textBox1.Text = "A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 619);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(withoutThreadButton);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button withoutThreadButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
    }
}
