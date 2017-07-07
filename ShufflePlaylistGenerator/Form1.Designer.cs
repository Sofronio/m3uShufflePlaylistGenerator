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
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.listBox_Ad = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_orderNormal = new System.Windows.Forms.RadioButton();
            this.radioButton_orderShuffle = new System.Windows.Forms.RadioButton();
            this.numericUpDown_Repeat = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ClearInput = new System.Windows.Forms.Button();
            this.button_ClearAd = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_ext_including = new System.Windows.Forms.TextBox();
            this.textBox_ext_excluding = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_ext_excluding = new System.Windows.Forms.RadioButton();
            this.radioButton_ext_including = new System.Windows.Forms.RadioButton();
            this.button_ClearList = new System.Windows.Forms.Button();
            this.listBox_List = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Ad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_WithAd = new System.Windows.Forms.RadioButton();
            this.radioButton_NoAd = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Repeat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ad)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(813, 744);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(238, 48);
            this.button_Generate.TabIndex = 0;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // listBox_Input
            // 
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.HorizontalScrollbar = true;
            this.listBox_Input.ItemHeight = 21;
            this.listBox_Input.Location = new System.Drawing.Point(65, 37);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(788, 130);
            this.listBox_Input.TabIndex = 1;
            // 
            // listBox_Ad
            // 
            this.listBox_Ad.FormattingEnabled = true;
            this.listBox_Ad.HorizontalScrollbar = true;
            this.listBox_Ad.ItemHeight = 21;
            this.listBox_Ad.Location = new System.Drawing.Point(65, 192);
            this.listBox_Ad.Name = "listBox_Ad";
            this.listBox_Ad.Size = new System.Drawing.Size(788, 130);
            this.listBox_Ad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(909, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Repeat times";
            // 
            // radioButton_orderNormal
            // 
            this.radioButton_orderNormal.AutoSize = true;
            this.radioButton_orderNormal.Location = new System.Drawing.Point(26, 39);
            this.radioButton_orderNormal.Name = "radioButton_orderNormal";
            this.radioButton_orderNormal.Size = new System.Drawing.Size(101, 25);
            this.radioButton_orderNormal.TabIndex = 5;
            this.radioButton_orderNormal.Text = "Normal";
            this.radioButton_orderNormal.UseVisualStyleBackColor = true;
            // 
            // radioButton_orderShuffle
            // 
            this.radioButton_orderShuffle.AutoSize = true;
            this.radioButton_orderShuffle.Checked = true;
            this.radioButton_orderShuffle.Location = new System.Drawing.Point(26, 78);
            this.radioButton_orderShuffle.Name = "radioButton_orderShuffle";
            this.radioButton_orderShuffle.Size = new System.Drawing.Size(112, 25);
            this.radioButton_orderShuffle.TabIndex = 6;
            this.radioButton_orderShuffle.TabStop = true;
            this.radioButton_orderShuffle.Text = "Shuffle";
            this.radioButton_orderShuffle.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Repeat
            // 
            this.numericUpDown_Repeat.Location = new System.Drawing.Point(913, 566);
            this.numericUpDown_Repeat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Repeat.Name = "numericUpDown_Repeat";
            this.numericUpDown_Repeat.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown_Repeat.TabIndex = 7;
            this.numericUpDown_Repeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_orderShuffle);
            this.groupBox1.Controls.Add(this.radioButton_orderNormal);
            this.groupBox1.Location = new System.Drawing.Point(65, 527);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist order";
            // 
            // button_ClearInput
            // 
            this.button_ClearInput.Location = new System.Drawing.Point(915, 37);
            this.button_ClearInput.Name = "button_ClearInput";
            this.button_ClearInput.Size = new System.Drawing.Size(136, 130);
            this.button_ClearInput.TabIndex = 9;
            this.button_ClearInput.Text = "Clear Input Video";
            this.button_ClearInput.UseVisualStyleBackColor = true;
            this.button_ClearInput.Click += new System.EventHandler(this.button_ClearInput_Click);
            // 
            // button_ClearAd
            // 
            this.button_ClearAd.Location = new System.Drawing.Point(915, 192);
            this.button_ClearAd.Name = "button_ClearAd";
            this.button_ClearAd.Size = new System.Drawing.Size(136, 130);
            this.button_ClearAd.TabIndex = 10;
            this.button_ClearAd.Text = "Clear Ad Video";
            this.button_ClearAd.UseVisualStyleBackColor = true;
            this.button_ClearAd.Click += new System.EventHandler(this.button_ClearAd_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(813, 822);
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
            this.groupBox2.Location = new System.Drawing.Point(328, 527);
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
            // button_ClearList
            // 
            this.button_ClearList.Location = new System.Drawing.Point(915, 347);
            this.button_ClearList.Name = "button_ClearList";
            this.button_ClearList.Size = new System.Drawing.Size(136, 130);
            this.button_ClearList.TabIndex = 13;
            this.button_ClearList.Text = "Clear Playlist";
            this.button_ClearList.UseVisualStyleBackColor = true;
            this.button_ClearList.Click += new System.EventHandler(this.button_ClearList_Click);
            // 
            // listBox_List
            // 
            this.listBox_List.FormattingEnabled = true;
            this.listBox_List.HorizontalScrollbar = true;
            this.listBox_List.ItemHeight = 21;
            this.listBox_List.Location = new System.Drawing.Point(65, 347);
            this.listBox_List.Name = "listBox_List";
            this.listBox_List.Size = new System.Drawing.Size(788, 130);
            this.listBox_List.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown_Ad);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.radioButton_WithAd);
            this.groupBox3.Controls.Add(this.radioButton_NoAd);
            this.groupBox3.Location = new System.Drawing.Point(65, 705);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 194);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Advertisment";
            // 
            // numericUpDown_Ad
            // 
            this.numericUpDown_Ad.Location = new System.Drawing.Point(47, 120);
            this.numericUpDown_Ad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Ad.Name = "numericUpDown_Ad";
            this.numericUpDown_Ad.Size = new System.Drawing.Size(75, 31);
            this.numericUpDown_Ad.TabIndex = 9;
            this.numericUpDown_Ad.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Video";
            // 
            // radioButton_WithAd
            // 
            this.radioButton_WithAd.AutoSize = true;
            this.radioButton_WithAd.Checked = true;
            this.radioButton_WithAd.Location = new System.Drawing.Point(26, 78);
            this.radioButton_WithAd.Name = "radioButton_WithAd";
            this.radioButton_WithAd.Size = new System.Drawing.Size(167, 25);
            this.radioButton_WithAd.TabIndex = 6;
            this.radioButton_WithAd.TabStop = true;
            this.radioButton_WithAd.Text = "Add Ad Every";
            this.radioButton_WithAd.UseVisualStyleBackColor = true;
            // 
            // radioButton_NoAd
            // 
            this.radioButton_NoAd.AutoSize = true;
            this.radioButton_NoAd.Location = new System.Drawing.Point(26, 39);
            this.radioButton_NoAd.Name = "radioButton_NoAd";
            this.radioButton_NoAd.Size = new System.Drawing.Size(90, 25);
            this.radioButton_NoAd.TabIndex = 5;
            this.radioButton_NoAd.Text = "No Ad";
            this.radioButton_NoAd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 969);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_ClearList);
            this.Controls.Add(this.listBox_List);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_ClearAd);
            this.Controls.Add(this.button_ClearInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown_Repeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Ad);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.button_Generate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "m3u playlist generator by Sofronio v0.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Repeat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.ListBox listBox_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_orderNormal;
        private System.Windows.Forms.RadioButton radioButton_orderShuffle;
        private System.Windows.Forms.NumericUpDown numericUpDown_Repeat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ClearInput;
        private System.Windows.Forms.Button button_ClearAd;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_ext_including;
        private System.Windows.Forms.TextBox textBox_ext_excluding;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_ext_excluding;
        private System.Windows.Forms.RadioButton radioButton_ext_including;
        private System.Windows.Forms.Button button_ClearList;
        private System.Windows.Forms.ListBox listBox_List;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_WithAd;
        private System.Windows.Forms.RadioButton radioButton_NoAd;
    }
}

