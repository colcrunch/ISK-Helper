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
            this.label5 = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.get_end = new System.Windows.Forms.Button();
            this.get_start = new System.Windows.Forms.Button();
            this.endTime = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.charName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.get_end);
            this.groupBox1.Controls.Add(this.get_start);
            this.groupBox1.Controls.Add(this.endTime);
            this.groupBox1.Controls.Add(this.startTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.charName);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character";
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
            // pay
            // 
            this.pay.DecimalPlaces = 2;
            this.pay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pay.Location = new System.Drawing.Point(53, 146);
            this.pay.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(94, 22);
            this.pay.TabIndex = 9;
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
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(93, 95);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(57, 22);
            this.endTime.TabIndex = 5;
            this.endTime.Text = "00:00";
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(93, 67);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(57, 22);
            this.startTime.TabIndex = 4;
            this.startTime.Text = "00:00";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Time:";
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
            // charName
            // 
            this.charName.Location = new System.Drawing.Point(62, 18);
            this.charName.Name = "charName";
            this.charName.Size = new System.Drawing.Size(108, 22);
            this.charName.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.pay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button get_end;
        private System.Windows.Forms.Button get_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown pay;
        public System.Windows.Forms.TextBox endTime;
        public System.Windows.Forms.TextBox startTime;
        public System.Windows.Forms.TextBox charName;
    }
}
