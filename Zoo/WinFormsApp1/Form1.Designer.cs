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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button3 = new Button();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            button4 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button5 = new Button();
            listBox3 = new ListBox();
            button6 = new Button();
            listBox4 = new ListBox();
            button7 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button8 = new Button();
            button9 = new Button();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button15 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(123, 12);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 0;
            button1.Text = "buy aviary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1099, 16);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(105, 23);
            button2.TabIndex = 2;
            button2.Text = "Get zoo info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(156, 38);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 66);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "cost";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(232, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "meat";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(283, 40);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "grass";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(232, 12);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 8;
            button3.Text = "buy food";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 38);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 10;
            label5.Text = "area";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(265, 64);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(70, 23);
            numericUpDown2.TabIndex = 11;
            numericUpDown2.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // button4
            // 
            button4.Location = new Point(341, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "buy animal";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(422, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(110, 109);
            listBox1.TabIndex = 13;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(538, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(110, 109);
            listBox2.TabIndex = 14;
            // 
            // button5
            // 
            button5.Location = new Point(986, 12);
            button5.Name = "button5";
            button5.Size = new Size(107, 23);
            button5.TabIndex = 16;
            button5.Text = "Let visitors in";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(754, 12);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(110, 109);
            listBox3.TabIndex = 17;
            // 
            // button6
            // 
            button6.Location = new Point(654, 12);
            button6.Name = "button6";
            button6.Size = new Size(94, 23);
            button6.TabIndex = 18;
            button6.Text = "feed animal";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(870, 12);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(110, 109);
            listBox4.TabIndex = 19;
            // 
            // button7
            // 
            button7.Location = new Point(654, 41);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 20;
            button7.Text = "kill animal";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button10
            // 
            button10.Location = new Point(12, 169);
            button10.Name = "button10";
            button10.Size = new Size(207, 48);
            button10.TabIndex = 23;
            button10.Text = "write data nodigit uppercase";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(225, 169);
            button11.Name = "button11";
            button11.Size = new Size(207, 48);
            button11.TabIndex = 24;
            button11.Text = "write to bianry";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(225, 223);
            button12.Name = "button12";
            button12.Size = new Size(207, 48);
            button12.TabIndex = 25;
            button12.Text = "read binary";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(441, 169);
            button13.Name = "button13";
            button13.Size = new Size(207, 48);
            button13.TabIndex = 26;
            button13.Text = "write to text";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(441, 223);
            button14.Name = "button14";
            button14.Size = new Size(207, 48);
            button14.TabIndex = 27;
            button14.Text = "read to text";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button8
            // 
            button8.Location = new Point(654, 169);
            button8.Name = "button8";
            button8.Size = new Size(207, 48);
            button8.TabIndex = 28;
            button8.Text = "Serialize Food";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // button9
            // 
            button9.Location = new Point(654, 223);
            button9.Name = "button9";
            button9.Size = new Size(207, 48);
            button9.TabIndex = 29;
            button9.Text = "DeSerialize Food";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(93, 420);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(38, 19);
            radioButton3.TabIndex = 31;
            radioButton3.TabStop = true;
            radioButton3.Text = "en";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(137, 420);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(36, 19);
            radioButton4.TabIndex = 30;
            radioButton4.TabStop = true;
            radioButton4.Text = "ru";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(12, 416);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 32;
            button15.Text = "Apply";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 451);
            Controls.Add(button15);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(listBox4);
            Controls.Add(button6);
            Controls.Add(listBox3);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(numericUpDown2);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button3;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private Button button4;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button5;
        private ListBox listBox3;
        private Button button6;
        private ListBox listBox4;
        private Button button7;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button8;
        private Button button9;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button15;
    }
}