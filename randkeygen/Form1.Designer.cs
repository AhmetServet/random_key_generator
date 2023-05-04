namespace randkeygen
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
            chkLetters = new CheckBox();
            chkNumbers = new CheckBox();
            chkOthers = new CheckBox();
            generatedKeyBox = new TextBox();
            copy = new Button();
            generate = new Button();
            charNumBox = new NumericUpDown();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)charNumBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // chkLetters
            // 
            chkLetters.AutoSize = true;
            chkLetters.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkLetters.Location = new Point(35, 21);
            chkLetters.Name = "chkLetters";
            chkLetters.Size = new Size(70, 23);
            chkLetters.TabIndex = 2;
            chkLetters.Text = "Letters";
            chkLetters.UseVisualStyleBackColor = true;
            chkLetters.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkNumbers
            // 
            chkNumbers.AutoSize = true;
            chkNumbers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkNumbers.Location = new Point(35, 46);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(84, 23);
            chkNumbers.TabIndex = 3;
            chkNumbers.Text = "Numbers";
            chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkOthers
            // 
            chkOthers.AutoSize = true;
            chkOthers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkOthers.Location = new Point(35, 71);
            chkOthers.Name = "chkOthers";
            chkOthers.Size = new Size(133, 23);
            chkOthers.TabIndex = 4;
            chkOthers.Text = "Other Characters";
            chkOthers.UseVisualStyleBackColor = true;
            // 
            // generatedKeyBox
            // 
            generatedKeyBox.BackColor = SystemColors.ControlLightLight;
            generatedKeyBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            generatedKeyBox.Location = new Point(12, 145);
            generatedKeyBox.Name = "generatedKeyBox";
            generatedKeyBox.ReadOnly = true;
            generatedKeyBox.Size = new Size(354, 29);
            generatedKeyBox.TabIndex = 6;
            generatedKeyBox.TextAlign = HorizontalAlignment.Center;
            generatedKeyBox.TextChanged += generatedKeyBox_TextChanged;
            // 
            // copy
            // 
            copy.Location = new Point(12, 180);
            copy.Name = "copy";
            copy.Size = new Size(115, 30);
            copy.TabIndex = 7;
            copy.Text = "Copy";
            copy.UseVisualStyleBackColor = true;
            copy.Click += copy_Click;
            // 
            // generate
            // 
            generate.Location = new Point(133, 178);
            generate.Name = "generate";
            generate.Size = new Size(233, 31);
            generate.TabIndex = 8;
            generate.Text = "Generate Key";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // charNumBox
            // 
            charNumBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            charNumBox.Location = new Point(18, 22);
            charNumBox.Name = "charNumBox";
            charNumBox.Size = new Size(120, 25);
            charNumBox.TabIndex = 11;
            charNumBox.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkOthers);
            groupBox1.Controls.Add(chkLetters);
            groupBox1.Controls.Add(chkNumbers);
            groupBox1.Location = new Point(173, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "The key will contain";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(charNumBox);
            groupBox2.Location = new Point(11, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(156, 62);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Key length";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 218);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(generate);
            Controls.Add(copy);
            Controls.Add(generatedKeyBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Random Key Generator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)charNumBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox chkLetters;
        private CheckBox chkNumbers;
        private CheckBox chkOthers;
        private TextBox generatedKeyBox;
        private Button copy;
        private Button generate;
        private NumericUpDown charNumBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}