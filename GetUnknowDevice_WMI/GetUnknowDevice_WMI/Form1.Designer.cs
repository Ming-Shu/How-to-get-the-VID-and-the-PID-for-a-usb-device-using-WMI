namespace GetUnknowDevice_WMI
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
            this.Lst_listBox = new System.Windows.Forms.ListBox();
            this.detect_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vid_textBox = new System.Windows.Forms.TextBox();
            this.vid_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pid_textBox = new System.Windows.Forms.TextBox();
            this.clean_button = new System.Windows.Forms.Button();
            this.specDetect_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lst_listBox
            // 
            this.Lst_listBox.FormattingEnabled = true;
            this.Lst_listBox.ItemHeight = 12;
            this.Lst_listBox.Location = new System.Drawing.Point(12, 150);
            this.Lst_listBox.Name = "Lst_listBox";
            this.Lst_listBox.Size = new System.Drawing.Size(804, 364);
            this.Lst_listBox.TabIndex = 0;
            // 
            // detect_button
            // 
            this.detect_button.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detect_button.Location = new System.Drawing.Point(486, 32);
            this.detect_button.Name = "detect_button";
            this.detect_button.Size = new System.Drawing.Size(144, 81);
            this.detect_button.TabIndex = 1;
            this.detect_button.Text = "All Detect";
            this.detect_button.UseVisualStyleBackColor = true;
            this.detect_button.Click += new System.EventHandler(this.detect_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.specDetect_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pid_textBox);
            this.groupBox1.Controls.Add(this.vid_label);
            this.groupBox1.Controls.Add(this.vid_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specific Detect";
            // 
            // vid_textBox
            // 
            this.vid_textBox.Location = new System.Drawing.Point(63, 20);
            this.vid_textBox.Name = "vid_textBox";
            this.vid_textBox.Size = new System.Drawing.Size(100, 27);
            this.vid_textBox.TabIndex = 0;
            // 
            // vid_label
            // 
            this.vid_label.AutoSize = true;
            this.vid_label.Location = new System.Drawing.Point(22, 24);
            this.vid_label.Name = "vid_label";
            this.vid_label.Size = new System.Drawing.Size(36, 19);
            this.vid_label.TabIndex = 1;
            this.vid_label.Text = "VID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "PID:";
            // 
            // pid_textBox
            // 
            this.pid_textBox.Location = new System.Drawing.Point(62, 54);
            this.pid_textBox.Name = "pid_textBox";
            this.pid_textBox.Size = new System.Drawing.Size(100, 27);
            this.pid_textBox.TabIndex = 2;
            // 
            // clean_button
            // 
            this.clean_button.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.clean_button.Location = new System.Drawing.Point(649, 33);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(148, 81);
            this.clean_button.TabIndex = 3;
            this.clean_button.Text = "All Clean";
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // specDetect_button
            // 
            this.specDetect_button.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.specDetect_button.Location = new System.Drawing.Point(219, 16);
            this.specDetect_button.Name = "specDetect_button";
            this.specDetect_button.Size = new System.Drawing.Size(144, 81);
            this.specDetect_button.TabIndex = 4;
            this.specDetect_button.Text = "Detect";
            this.specDetect_button.UseVisualStyleBackColor = true;
            this.specDetect_button.Click += new System.EventHandler(this.specDetect_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 525);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detect_button);
            this.Controls.Add(this.Lst_listBox);
            this.Name = "Form1";
            this.Text = "Device Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lst_listBox;
        private System.Windows.Forms.Button detect_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button specDetect_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pid_textBox;
        private System.Windows.Forms.Label vid_label;
        private System.Windows.Forms.TextBox vid_textBox;
        private System.Windows.Forms.Button clean_button;
    }
}

