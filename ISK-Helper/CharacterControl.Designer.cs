namespace ISK_Helper
{
    partial class CharacterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.starttime = new System.Windows.Forms.TextBox();
            this.endtime = new System.Windows.Forms.TextBox();
            this.get_start = new System.Windows.Forms.Button();
            this.get_end = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.get_end);
            this.groupBox1.Controls.Add(this.get_start);
            this.groupBox1.Controls.Add(this.endtime);
            this.groupBox1.Controls.Add(this.starttime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Time:";
            // 
            // starttime
            // 
            this.starttime.Location = new System.Drawing.Point(93, 67);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(57, 22);
            this.starttime.TabIndex = 4;
            this.starttime.Text = "00:00";
            // 
            // endtime
            // 
            this.endtime.Location = new System.Drawing.Point(93, 95);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(57, 22);
            this.endtime.TabIndex = 5;
            this.endtime.Text = "00:00";
            // 
            // get_start
            // 
            this.get_start.Location = new System.Drawing.Point(156, 67);
            this.get_start.Name = "get_start";
            this.get_start.Size = new System.Drawing.Size(76, 25);
            this.get_start.TabIndex = 6;
            this.get_start.Text = "Get Time";
            this.get_start.UseVisualStyleBackColor = true;
            this.get_start.Click += new System.EventHandler(this.get_start_Click);
            // 
            // get_end
            // 
            this.get_end.Location = new System.Drawing.Point(156, 95);
            this.get_end.Name = "get_end";
            this.get_end.Size = new System.Drawing.Size(76, 25);
            this.get_end.TabIndex = 7;
            this.get_end.Text = "Get Time";
            this.get_end.UseVisualStyleBackColor = true;
            this.get_end.Click += new System.EventHandler(this.get_end_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pay:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(53, 146);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Million ISK";
            // 
            // CharacterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CharacterControl";
            this.Size = new System.Drawing.Size(245, 205);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button get_end;
        private System.Windows.Forms.Button get_start;
        private System.Windows.Forms.TextBox endtime;
        private System.Windows.Forms.TextBox starttime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
