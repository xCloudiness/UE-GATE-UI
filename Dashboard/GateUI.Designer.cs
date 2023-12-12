namespace Dashboard
{
    partial class GateUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GateUI));
            this.ConnectDB = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.GroupBox();
            this.OKInput2 = new System.Windows.Forms.Button();
            this.OKInput1 = new System.Windows.Forms.Button();
            this.IDInput2 = new System.Windows.Forms.TextBox();
            this.IDInput1 = new System.Windows.Forms.TextBox();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViolationBox2 = new System.Windows.Forms.ComboBox();
            this.StudentID2 = new System.Windows.Forms.Label();
            this.StudentName2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Violations = new System.Windows.Forms.ComboBox();
            this.StudentID1 = new System.Windows.Forms.Label();
            this.StudentName1 = new System.Windows.Forms.Label();
            this.StudentImage2 = new System.Windows.Forms.PictureBox();
            this.StudentImage1 = new System.Windows.Forms.PictureBox();
            this.InputBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectDB
            // 
            this.ConnectDB.Location = new System.Drawing.Point(0, 0);
            this.ConnectDB.Name = "ConnectDB";
            this.ConnectDB.Size = new System.Drawing.Size(110, 31);
            this.ConnectDB.TabIndex = 2;
            this.ConnectDB.Text = "DB TEST";
            this.ConnectDB.UseVisualStyleBackColor = true;
            this.ConnectDB.Click += new System.EventHandler(this.ConnectDB_Click);
            // 
            // InputBox
            // 
            this.InputBox.Controls.Add(this.OKInput2);
            this.InputBox.Controls.Add(this.OKInput1);
            this.InputBox.Controls.Add(this.IDInput2);
            this.InputBox.Controls.Add(this.IDInput1);
            this.InputBox.Controls.Add(this.CurrentDate);
            this.InputBox.Controls.Add(this.CurrentTime);
            this.InputBox.Controls.Add(this.ConnectDB);
            this.InputBox.Location = new System.Drawing.Point(12, 25);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(358, 722);
            this.InputBox.TabIndex = 3;
            this.InputBox.TabStop = false;
            // 
            // OKInput2
            // 
            this.OKInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.OKInput2.Location = new System.Drawing.Point(232, 364);
            this.OKInput2.Name = "OKInput2";
            this.OKInput2.Size = new System.Drawing.Size(68, 23);
            this.OKInput2.TabIndex = 8;
            this.OKInput2.Text = "OK";
            this.OKInput2.UseVisualStyleBackColor = true;
            this.OKInput2.Click += new System.EventHandler(this.OKInput2_Click);
            // 
            // OKInput1
            // 
            this.OKInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.OKInput1.Location = new System.Drawing.Point(236, 176);
            this.OKInput1.Name = "OKInput1";
            this.OKInput1.Size = new System.Drawing.Size(68, 23);
            this.OKInput1.TabIndex = 7;
            this.OKInput1.Text = "OK";
            this.OKInput1.UseVisualStyleBackColor = true;
            this.OKInput1.Click += new System.EventHandler(this.OKInput1_Click);
            // 
            // IDInput2
            // 
            this.IDInput2.Location = new System.Drawing.Point(70, 361);
            this.IDInput2.Name = "IDInput2";
            this.IDInput2.Size = new System.Drawing.Size(153, 26);
            this.IDInput2.TabIndex = 6;
            this.IDInput2.TextChanged += new System.EventHandler(this.IDInput2_TextChanged);
            // 
            // IDInput1
            // 
            this.IDInput1.Location = new System.Drawing.Point(70, 176);
            this.IDInput1.Name = "IDInput1";
            this.IDInput1.Size = new System.Drawing.Size(153, 26);
            this.IDInput1.TabIndex = 5;
            this.IDInput1.TextChanged += new System.EventHandler(this.IDInput1_TextChanged);
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.CurrentDate.Location = new System.Drawing.Point(79, 598);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(186, 36);
            this.CurrentDate.TabIndex = 4;
            this.CurrentDate.Text = "CurrentDate";
            this.CurrentDate.Click += new System.EventHandler(this.CurrentDate_Click);
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.CurrentTime.Location = new System.Drawing.Point(79, 541);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(189, 36);
            this.CurrentTime.TabIndex = 3;
            this.CurrentTime.Text = "CurrentTime";
            this.CurrentTime.Click += new System.EventHandler(this.CurrentTime_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ViolationBox2);
            this.groupBox2.Controls.Add(this.StudentID2);
            this.groupBox2.Controls.Add(this.StudentName2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Violations);
            this.groupBox2.Controls.Add(this.StudentID1);
            this.groupBox2.Controls.Add(this.StudentName1);
            this.groupBox2.Controls.Add(this.StudentImage2);
            this.groupBox2.Controls.Add(this.StudentImage1);
            this.groupBox2.Location = new System.Drawing.Point(432, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 667);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Violations:";
            // 
            // ViolationBox2
            // 
            this.ViolationBox2.FormattingEnabled = true;
            this.ViolationBox2.Items.AddRange(new object[] {
            "(None)",
            "Uniform Violation",
            "ID Violation"});
            this.ViolationBox2.Location = new System.Drawing.Point(328, 478);
            this.ViolationBox2.Name = "ViolationBox2";
            this.ViolationBox2.Size = new System.Drawing.Size(176, 28);
            this.ViolationBox2.TabIndex = 20;
            this.ViolationBox2.SelectedIndexChanged += new System.EventHandler(this.ViolationBox2_SelectedIndexChanged);
            // 
            // StudentID2
            // 
            this.StudentID2.AutoSize = true;
            this.StudentID2.Location = new System.Drawing.Point(324, 395);
            this.StudentID2.Name = "StudentID2";
            this.StudentID2.Size = new System.Drawing.Size(110, 20);
            this.StudentID2.TabIndex = 19;
            this.StudentID2.Text = "Student ID: ";
            // 
            // StudentName2
            // 
            this.StudentName2.AutoSize = true;
            this.StudentName2.Location = new System.Drawing.Point(324, 358);
            this.StudentName2.Name = "StudentName2";
            this.StudentName2.Size = new System.Drawing.Size(69, 20);
            this.StudentName2.TabIndex = 18;
            this.StudentName2.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Violations:";
            // 
            // Violations
            // 
            this.Violations.FormattingEnabled = true;
            this.Violations.Items.AddRange(new object[] {
            "(None)",
            "Uniform Violation",
            "ID Violation"});
            this.Violations.Location = new System.Drawing.Point(328, 216);
            this.Violations.Name = "Violations";
            this.Violations.Size = new System.Drawing.Size(176, 28);
            this.Violations.TabIndex = 16;
            this.Violations.SelectedIndexChanged += new System.EventHandler(this.Violations_SelectedIndexChanged);
            // 
            // StudentID1
            // 
            this.StudentID1.AutoSize = true;
            this.StudentID1.Location = new System.Drawing.Point(324, 133);
            this.StudentID1.Name = "StudentID1";
            this.StudentID1.Size = new System.Drawing.Size(110, 20);
            this.StudentID1.TabIndex = 15;
            this.StudentID1.Text = "Student ID: ";
            // 
            // StudentName1
            // 
            this.StudentName1.AutoSize = true;
            this.StudentName1.Location = new System.Drawing.Point(324, 96);
            this.StudentName1.Name = "StudentName1";
            this.StudentName1.Size = new System.Drawing.Size(69, 20);
            this.StudentName1.TabIndex = 14;
            this.StudentName1.Text = "Name: ";
            // 
            // StudentImage2
            // 
            this.StudentImage2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StudentImage2.Location = new System.Drawing.Point(107, 354);
            this.StudentImage2.Name = "StudentImage2";
            this.StudentImage2.Size = new System.Drawing.Size(195, 187);
            this.StudentImage2.TabIndex = 11;
            this.StudentImage2.TabStop = false;
            // 
            // StudentImage1
            // 
            this.StudentImage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StudentImage1.Location = new System.Drawing.Point(107, 88);
            this.StudentImage1.Name = "StudentImage1";
            this.StudentImage1.Size = new System.Drawing.Size(195, 187);
            this.StudentImage1.TabIndex = 10;
            this.StudentImage1.TabStop = false;
            // 
            // GateUI
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1313, 769);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InputBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "GateUI";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputBox.ResumeLayout(false);
            this.InputBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ConnectDB;
        private System.Windows.Forms.GroupBox InputBox;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.TextBox IDInput1;
        private System.Windows.Forms.TextBox IDInput2;
        private System.Windows.Forms.Button OKInput2;
        private System.Windows.Forms.Button OKInput1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox StudentImage2;
        private System.Windows.Forms.PictureBox StudentImage1;
        private System.Windows.Forms.Label StudentID1;
        private System.Windows.Forms.Label StudentName1;
        private System.Windows.Forms.ComboBox Violations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ViolationBox2;
        private System.Windows.Forms.Label StudentID2;
        private System.Windows.Forms.Label StudentName2;
    }
}

