namespace SoftwareProcess
{
    partial class frmAddPaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPaper));
            this.btnPreAdd = new System.Windows.Forms.Button();
            this.btnPreRemove = new System.Windows.Forms.Button();
            this.tbxPaperName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.lstAPapers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPaperCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAPapers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkWebDev = new System.Windows.Forms.CheckBox();
            this.chkSoftwareArch = new System.Windows.Forms.CheckBox();
            this.chkAnal = new System.Windows.Forms.CheckBox();
            this.chkNetwork = new System.Windows.Forms.CheckBox();
            this.chkDB = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkACompulsory = new System.Windows.Forms.CheckBox();
            this.chkAYear2 = new System.Windows.Forms.CheckBox();
            this.chkAYear3 = new System.Windows.Forms.CheckBox();
            this.chkAYear1 = new System.Windows.Forms.CheckBox();
            this.chkArchive = new System.Windows.Forms.CheckBox();
            this.cboLecturer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radSem1 = new System.Windows.Forms.RadioButton();
            this.radSemBoth = new System.Windows.Forms.RadioButton();
            this.radSem2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreAdd
            // 
            this.btnPreAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreAdd.Location = new System.Drawing.Point(7, 318);
            this.btnPreAdd.Name = "btnPreAdd";
            this.btnPreAdd.Size = new System.Drawing.Size(121, 23);
            this.btnPreAdd.TabIndex = 0;
            this.btnPreAdd.Text = "Add";
            this.btnPreAdd.UseVisualStyleBackColor = true;
            this.btnPreAdd.Click += new System.EventHandler(this.btnPreAdd_Click);
            // 
            // btnPreRemove
            // 
            this.btnPreRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreRemove.Location = new System.Drawing.Point(133, 318);
            this.btnPreRemove.Name = "btnPreRemove";
            this.btnPreRemove.Size = new System.Drawing.Size(120, 23);
            this.btnPreRemove.TabIndex = 1;
            this.btnPreRemove.Text = "Remove";
            this.btnPreRemove.UseVisualStyleBackColor = true;
            this.btnPreRemove.Click += new System.EventHandler(this.btnPreRemove_Click);
            // 
            // tbxPaperName
            // 
            this.tbxPaperName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPaperName.Location = new System.Drawing.Point(78, 46);
            this.tbxPaperName.Name = "tbxPaperName";
            this.tbxPaperName.Size = new System.Drawing.Size(308, 20);
            this.tbxPaperName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paper Name";
            // 
            // tbxDesc
            // 
            this.tbxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesc.Location = new System.Drawing.Point(78, 72);
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(308, 108);
            this.tbxDesc.TabIndex = 3;
            // 
            // lstAPapers
            // 
            this.lstAPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAPapers.FormattingEnabled = true;
            this.lstAPapers.Location = new System.Drawing.Point(7, 48);
            this.lstAPapers.Name = "lstAPapers";
            this.lstAPapers.Size = new System.Drawing.Size(246, 264);
            this.lstAPapers.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPaperCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxDesc);
            this.groupBox1.Controls.Add(this.tbxPaperName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 186);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paper Information";
            // 
            // tbxPaperCode
            // 
            this.tbxPaperCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPaperCode.Location = new System.Drawing.Point(78, 20);
            this.tbxPaperCode.Name = "tbxPaperCode";
            this.tbxPaperCode.Size = new System.Drawing.Size(82, 20);
            this.tbxPaperCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Paper Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description:";
            // 
            // cboAPapers
            // 
            this.cboAPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAPapers.FormattingEnabled = true;
            this.cboAPapers.Location = new System.Drawing.Point(6, 20);
            this.cboAPapers.Name = "cboAPapers";
            this.cboAPapers.Size = new System.Drawing.Size(247, 21);
            this.cboAPapers.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboAPapers);
            this.groupBox2.Controls.Add(this.lstAPapers);
            this.groupBox2.Controls.Add(this.btnPreRemove);
            this.groupBox2.Controls.Add(this.btnPreAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 352);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prerequisites";
            // 
            // chkWebDev
            // 
            this.chkWebDev.AutoSize = true;
            this.chkWebDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWebDev.Location = new System.Drawing.Point(6, 42);
            this.chkWebDev.Name = "chkWebDev";
            this.chkWebDev.Size = new System.Drawing.Size(115, 17);
            this.chkWebDev.TabIndex = 5;
            this.chkWebDev.Text = "Web Development";
            this.chkWebDev.UseVisualStyleBackColor = true;
            // 
            // chkSoftwareArch
            // 
            this.chkSoftwareArch.AutoSize = true;
            this.chkSoftwareArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoftwareArch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSoftwareArch.Location = new System.Drawing.Point(6, 19);
            this.chkSoftwareArch.Name = "chkSoftwareArch";
            this.chkSoftwareArch.Size = new System.Drawing.Size(128, 17);
            this.chkSoftwareArch.TabIndex = 4;
            this.chkSoftwareArch.Text = "Software Architecture";
            this.chkSoftwareArch.UseVisualStyleBackColor = true;
            // 
            // chkAnal
            // 
            this.chkAnal.AutoSize = true;
            this.chkAnal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnal.Location = new System.Drawing.Point(6, 65);
            this.chkAnal.Name = "chkAnal";
            this.chkAnal.Size = new System.Drawing.Size(119, 17);
            this.chkAnal.TabIndex = 6;
            this.chkAnal.Text = "Analysis and design";
            this.chkAnal.UseVisualStyleBackColor = true;
            // 
            // chkNetwork
            // 
            this.chkNetwork.AutoSize = true;
            this.chkNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNetwork.Location = new System.Drawing.Point(157, 19);
            this.chkNetwork.Name = "chkNetwork";
            this.chkNetwork.Size = new System.Drawing.Size(80, 17);
            this.chkNetwork.TabIndex = 7;
            this.chkNetwork.Text = "Networking";
            this.chkNetwork.UseVisualStyleBackColor = true;
            // 
            // chkDB
            // 
            this.chkDB.AutoSize = true;
            this.chkDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDB.Location = new System.Drawing.Point(157, 42);
            this.chkDB.Name = "chkDB";
            this.chkDB.Size = new System.Drawing.Size(138, 17);
            this.chkDB.TabIndex = 8;
            this.chkDB.Text = "Database Development";
            this.chkDB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDB);
            this.groupBox3.Controls.Add(this.chkWebDev);
            this.groupBox3.Controls.Add(this.chkNetwork);
            this.groupBox3.Controls.Add(this.chkSoftwareArch);
            this.groupBox3.Controls.Add(this.chkAnal);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 92);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Career Path";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(543, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(543, 391);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 23);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkACompulsory);
            this.groupBox4.Controls.Add(this.chkAYear2);
            this.groupBox4.Controls.Add(this.chkAYear3);
            this.groupBox4.Controls.Add(this.chkAYear1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 62);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Year/Compulsory";
            // 
            // chkACompulsory
            // 
            this.chkACompulsory.AutoSize = true;
            this.chkACompulsory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkACompulsory.Location = new System.Drawing.Point(157, 42);
            this.chkACompulsory.Name = "chkACompulsory";
            this.chkACompulsory.Size = new System.Drawing.Size(80, 17);
            this.chkACompulsory.TabIndex = 12;
            this.chkACompulsory.Text = "Compulsory";
            this.chkACompulsory.UseVisualStyleBackColor = true;
            // 
            // chkAYear2
            // 
            this.chkAYear2.AutoSize = true;
            this.chkAYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAYear2.Location = new System.Drawing.Point(6, 42);
            this.chkAYear2.Name = "chkAYear2";
            this.chkAYear2.Size = new System.Drawing.Size(57, 17);
            this.chkAYear2.TabIndex = 10;
            this.chkAYear2.Text = "Year 2";
            this.chkAYear2.UseVisualStyleBackColor = true;
            // 
            // chkAYear3
            // 
            this.chkAYear3.AutoSize = true;
            this.chkAYear3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAYear3.Location = new System.Drawing.Point(157, 19);
            this.chkAYear3.Name = "chkAYear3";
            this.chkAYear3.Size = new System.Drawing.Size(57, 17);
            this.chkAYear3.TabIndex = 11;
            this.chkAYear3.Text = "Year 3";
            this.chkAYear3.UseVisualStyleBackColor = true;
            // 
            // chkAYear1
            // 
            this.chkAYear1.AutoSize = true;
            this.chkAYear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAYear1.Location = new System.Drawing.Point(6, 19);
            this.chkAYear1.Name = "chkAYear1";
            this.chkAYear1.Size = new System.Drawing.Size(57, 17);
            this.chkAYear1.TabIndex = 9;
            this.chkAYear1.Text = "Year 1";
            this.chkAYear1.UseVisualStyleBackColor = true;
            // 
            // chkArchive
            // 
            this.chkArchive.AutoSize = true;
            this.chkArchive.Location = new System.Drawing.Point(169, 426);
            this.chkArchive.Name = "chkArchive";
            this.chkArchive.Size = new System.Drawing.Size(68, 17);
            this.chkArchive.TabIndex = 17;
            this.chkArchive.Text = "Archived";
            this.chkArchive.UseVisualStyleBackColor = true;
            // 
            // cboLecturer
            // 
            this.cboLecturer.FormattingEnabled = true;
            this.cboLecturer.Items.AddRange(new object[] {
            "SC",
            "AS",
            "GR",
            "RD",
            "KT"});
            this.cboLecturer.Location = new System.Drawing.Point(67, 422);
            this.cboLecturer.Name = "cboLecturer";
            this.cboLecturer.Size = new System.Drawing.Size(79, 21);
            this.cboLecturer.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lecturer";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radSem2);
            this.groupBox5.Controls.Add(this.radSemBoth);
            this.groupBox5.Controls.Add(this.radSem1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 370);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 45);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Semester";
            // 
            // radSem1
            // 
            this.radSem1.AutoSize = true;
            this.radSem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSem1.Location = new System.Drawing.Point(6, 19);
            this.radSem1.Name = "radSem1";
            this.radSem1.Size = new System.Drawing.Size(31, 17);
            this.radSem1.TabIndex = 0;
            this.radSem1.TabStop = true;
            this.radSem1.Text = "1";
            this.radSem1.UseVisualStyleBackColor = true;
            // 
            // radSemBoth
            // 
            this.radSemBoth.AutoSize = true;
            this.radSemBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSemBoth.Location = new System.Drawing.Point(167, 19);
            this.radSemBoth.Name = "radSemBoth";
            this.radSemBoth.Size = new System.Drawing.Size(47, 17);
            this.radSemBoth.TabIndex = 1;
            this.radSemBoth.TabStop = true;
            this.radSemBoth.Text = "Both";
            this.radSemBoth.UseVisualStyleBackColor = true;
            // 
            // radSem2
            // 
            this.radSem2.AutoSize = true;
            this.radSem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSem2.Location = new System.Drawing.Point(90, 19);
            this.radSem2.Name = "radSem2";
            this.radSem2.Size = new System.Drawing.Size(31, 17);
            this.radSem2.TabIndex = 2;
            this.radSem2.TabStop = true;
            this.radSem2.Text = "2";
            this.radSem2.UseVisualStyleBackColor = true;
            // 
            // frmAddPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 451);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboLecturer);
            this.Controls.Add(this.chkArchive);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddPaper";
            this.Text = "Add Paper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddPaper_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreAdd;
        private System.Windows.Forms.Button btnPreRemove;
        private System.Windows.Forms.TextBox tbxPaperName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.ListBox lstAPapers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboAPapers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkWebDev;
        private System.Windows.Forms.CheckBox chkSoftwareArch;
        private System.Windows.Forms.CheckBox chkAnal;
        private System.Windows.Forms.CheckBox chkNetwork;
        private System.Windows.Forms.CheckBox chkDB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkACompulsory;
        private System.Windows.Forms.CheckBox chkAYear2;
        private System.Windows.Forms.CheckBox chkAYear3;
        private System.Windows.Forms.CheckBox chkAYear1;
        private System.Windows.Forms.TextBox tbxPaperCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkArchive;
        private System.Windows.Forms.ComboBox cboLecturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radSem2;
        private System.Windows.Forms.RadioButton radSemBoth;
        private System.Windows.Forms.RadioButton radSem1;
    }
}