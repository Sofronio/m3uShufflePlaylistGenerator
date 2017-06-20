namespace ShufflePlayerlistGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Generate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Clear1 = new System.Windows.Forms.Button();
            this.button_Clear2 = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_ext_including = new System.Windows.Forms.TextBox();
            this.textBox_ext_excluding = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_ext_excluding = new System.Windows.Forms.RadioButton();
            this.radioButton_ext_including = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(1152, 368);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(238, 48);
            this.button_Generate.TabIndex = 0;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(65, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1162, 130);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(65, 203);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1162, 130);
            this.listBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(949, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Repeat times";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 25);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 25);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Shuffle";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(953, 407);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(66, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist order";
            // 
            // button_Clear1
            // 
            this.button_Clear1.Location = new System.Drawing.Point(1254, 37);
            this.button_Clear1.Name = "button_Clear1";
            this.button_Clear1.Size = new System.Drawing.Size(136, 130);
            this.button_Clear1.TabIndex = 9;
            this.button_Clear1.Text = "Clear";
            this.button_Clear1.UseVisualStyleBackColor = true;
            this.button_Clear1.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Clear2
            // 
            this.button_Clear2.Location = new System.Drawing.Point(1254, 203);
            this.button_Clear2.Name = "button_Clear2";
            this.button_Clear2.Size = new System.Drawing.Size(136, 130);
            this.button_Clear2.TabIndex = 10;
            this.button_Clear2.Text = "Clear";
            this.button_Clear2.UseVisualStyleBackColor = true;
            this.button_Clear2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(1152, 446);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(238, 48);
            this.button_Save.TabIndex = 11;
            this.button_Save.Text = "Save playlist as";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_ext_including
            // 
            this.textBox_ext_including.Location = new System.Drawing.Point(166, 39);
            this.textBox_ext_including.Name = "textBox_ext_including";
            this.textBox_ext_including.Size = new System.Drawing.Size(331, 31);
            this.textBox_ext_including.TabIndex = 13;
            this.textBox_ext_including.Text = "mp4,mkv";
            // 
            // textBox_ext_excluding
            // 
            this.textBox_ext_excluding.Location = new System.Drawing.Point(166, 78);
            this.textBox_ext_excluding.Name = "textBox_ext_excluding";
            this.textBox_ext_excluding.Size = new System.Drawing.Size(331, 31);
            this.textBox_ext_excluding.TabIndex = 14;
            this.textBox_ext_excluding.Text = "db,txt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_ext_excluding);
            this.groupBox2.Controls.Add(this.textBox_ext_excluding);
            this.groupBox2.Controls.Add(this.radioButton_ext_including);
            this.groupBox2.Controls.Add(this.textBox_ext_including);
            this.groupBox2.Location = new System.Drawing.Point(329, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 136);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File extention (seperate with ,  )";
            // 
            // radioButton_ext_excluding
            // 
            this.radioButton_ext_excluding.AutoSize = true;
            this.radioButton_ext_excluding.Location = new System.Drawing.Point(26, 78);
            this.radioButton_ext_excluding.Name = "radioButton_ext_excluding";
            this.radioButton_ext_excluding.Size = new System.Drawing.Size(134, 25);
            this.radioButton_ext_excluding.TabIndex = 6;
            this.radioButton_ext_excluding.Text = "Excluding";
            this.radioButton_ext_excluding.UseVisualStyleBackColor = true;
            // 
            // radioButton_ext_including
            // 
            this.radioButton_ext_including.AutoSize = true;
            this.radioButton_ext_including.Checked = true;
            this.radioButton_ext_including.Location = new System.Drawing.Point(26, 39);
            this.radioButton_ext_including.Name = "radioButton_ext_including";
            this.radioButton_ext_including.Size = new System.Drawing.Size(134, 25);
            this.radioButton_ext_including.TabIndex = 5;
            this.radioButton_ext_including.TabStop = true;
            this.radioButton_ext_including.Text = "Including";
            this.radioButton_ext_including.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Clear2);
            this.Controls.Add(this.button_Clear1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Generate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "m3u playlist generator by Sofronio v0.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Clear1;
        private System.Windows.Forms.Button button_Clear2;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_ext_including;
        private System.Windows.Forms.TextBox textBox_ext_excluding;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_ext_excluding;
        private System.Windows.Forms.RadioButton radioButton_ext_including;
    }
}

