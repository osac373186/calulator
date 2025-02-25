namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(82, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "算式";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(381, 67);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(36, 19);
            radioButton5.TabIndex = 1;
            radioButton5.Text = "%";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(52, 187);
            button1.Name = "button1";
            button1.Size = new Size(316, 23);
            button1.TabIndex = 15;
            button1.Text = "計算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 116);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 14;
            label2.Text = "=";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 116);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 13;
            label1.Text = "+";
            label1.Click += label1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(35, 113);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(73, 23);
            maskedTextBox1.TabIndex = 12;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(297, 67);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(30, 19);
            radioButton4.TabIndex = 11;
            radioButton4.Text = "/";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(213, 67);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(33, 19);
            radioButton3.TabIndex = 10;
            radioButton3.Text = "X";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(127, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(30, 19);
            radioButton2.TabIndex = 9;
            radioButton2.Text = "-";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.Menu;
            radioButton1.Location = new Point(25, 67);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(34, 19);
            radioButton1.TabIndex = 8;
            radioButton1.Text = "+";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(312, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(73, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 23);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton5;
    }
}