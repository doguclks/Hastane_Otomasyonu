namespace Hastane_Otomasyon
{
    partial class FrmPatientDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientDetails));
            this.GrpPatientInformation = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.LblNumberTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpAppointment = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbDoctors = new System.Windows.Forms.ComboBox();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GrpPatientInformation.SuspendLayout();
            this.GrpAppointment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpPatientInformation
            // 
            this.GrpPatientInformation.Controls.Add(this.linkLabel1);
            this.GrpPatientInformation.Controls.Add(this.LblNameSurname);
            this.GrpPatientInformation.Controls.Add(this.LblNumberTc);
            this.GrpPatientInformation.Controls.Add(this.label2);
            this.GrpPatientInformation.Controls.Add(this.label1);
            this.GrpPatientInformation.Location = new System.Drawing.Point(12, 12);
            this.GrpPatientInformation.Name = "GrpPatientInformation";
            this.GrpPatientInformation.Size = new System.Drawing.Size(338, 210);
            this.GrpPatientInformation.TabIndex = 0;
            this.GrpPatientInformation.TabStop = false;
            this.GrpPatientInformation.Text = "Patient Information";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(48, 163);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Edit Information";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(197, 121);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(77, 21);
            this.LblNameSurname.TabIndex = 3;
            this.LblNameSurname.Text = "Null Null";
            // 
            // LblNumberTc
            // 
            this.LblNumberTc.AutoSize = true;
            this.LblNumberTc.Location = new System.Drawing.Point(197, 77);
            this.LblNumberTc.Name = "LblNumberTc";
            this.LblNumberTc.Size = new System.Drawing.Size(109, 21);
            this.LblNumberTc.TabIndex = 2;
            this.LblNumberTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number(TC):";
            // 
            // GrpAppointment
            // 
            this.GrpAppointment.Controls.Add(this.textBox1);
            this.GrpAppointment.Controls.Add(this.label3);
            this.GrpAppointment.Controls.Add(this.button1);
            this.GrpAppointment.Controls.Add(this.label7);
            this.GrpAppointment.Controls.Add(this.richTextBox1);
            this.GrpAppointment.Controls.Add(this.label6);
            this.GrpAppointment.Controls.Add(this.label5);
            this.GrpAppointment.Controls.Add(this.CmbDoctors);
            this.GrpAppointment.Controls.Add(this.CmbBranch);
            this.GrpAppointment.Location = new System.Drawing.Point(12, 228);
            this.GrpAppointment.Name = "GrpAppointment";
            this.GrpAppointment.Size = new System.Drawing.Size(338, 336);
            this.GrpAppointment.TabIndex = 1;
            this.GrpAppointment.TabStop = false;
            this.GrpAppointment.Text = "Appointment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Make an Appointment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Complaint";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(119, 174);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 106);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Doctor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Branch";
            // 
            // CmbDoctors
            // 
            this.CmbDoctors.FormattingEnabled = true;
            this.CmbDoctors.Location = new System.Drawing.Point(119, 124);
            this.CmbDoctors.Name = "CmbDoctors";
            this.CmbDoctors.Size = new System.Drawing.Size(213, 29);
            this.CmbDoctors.TabIndex = 1;
            this.CmbDoctors.SelectedIndexChanged += new System.EventHandler(this.CmbDoctors_SelectedIndexChanged);
            // 
            // CmbBranch
            // 
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Location = new System.Drawing.Point(119, 76);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(213, 29);
            this.CmbBranch.TabIndex = 0;
            this.CmbBranch.SelectedIndexChanged += new System.EventHandler(this.CmbBranch_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(382, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(382, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 193);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active Appointment";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(673, 162);
            this.dataGridView2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 602);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "QUIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 29);
            this.textBox1.TabIndex = 8;
            // 
            // FrmPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1064, 666);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpAppointment);
            this.Controls.Add(this.GrpPatientInformation);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmPatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmPatientDetails_Load);
            this.GrpPatientInformation.ResumeLayout(false);
            this.GrpPatientInformation.PerformLayout();
            this.GrpAppointment.ResumeLayout(false);
            this.GrpAppointment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpPatientInformation;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label LblNumberTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpAppointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbDoctors;
        private System.Windows.Forms.ComboBox CmbBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}