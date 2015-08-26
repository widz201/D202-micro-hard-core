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
            this.btnPreAdd = new System.Windows.Forms.Button();
            this.btnPreRemove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lstAPapers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreAdd
            // 
            this.btnPreAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreAdd.Location = new System.Drawing.Point(6, 192);
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
            this.btnPreRemove.Location = new System.Drawing.Point(6, 221);
            this.btnPreRemove.Name = "btnPreRemove";
            this.btnPreRemove.Size = new System.Drawing.Size(121, 23);
            this.btnPreRemove.TabIndex = 1;
            this.btnPreRemove.Text = "Remove";
            this.btnPreRemove.UseVisualStyleBackColor = true;
            this.btnPreRemove.Click += new System.EventHandler(this.btnPreRemove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(78, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paper Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(78, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 108);
            this.textBox2.TabIndex = 4;
            // 
            // lstAPapers
            // 
            this.lstAPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAPapers.FormattingEnabled = true;
            this.lstAPapers.Location = new System.Drawing.Point(7, 39);
            this.lstAPapers.Name = "lstAPapers";
            this.lstAPapers.Size = new System.Drawing.Size(120, 147);
            this.lstAPapers.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paper Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            // 
            // cboAPapers
            // 
            this.cboAPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAPapers.FormattingEnabled = true;
            this.cboAPapers.Location = new System.Drawing.Point(7, 13);
            this.cboAPapers.Name = "cboAPapers";
            this.cboAPapers.Size = new System.Drawing.Size(120, 21);
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
            this.groupBox2.Size = new System.Drawing.Size(133, 250);
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
            this.chkWebDev.TabIndex = 10;
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
            this.chkSoftwareArch.TabIndex = 8;
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
            this.chkAnal.TabIndex = 12;
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
            this.chkNetwork.TabIndex = 9;
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
            this.chkDB.TabIndex = 11;
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
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 92);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Career Path";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(417, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(417, 281);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 23);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkACompulsory);
            this.groupBox4.Controls.Add(this.chkAYear2);
            this.groupBox4.Controls.Add(this.chkAYear3);
            this.groupBox4.Controls.Add(this.chkAYear1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 73);
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
            this.chkACompulsory.TabIndex = 3;
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
            this.chkAYear2.TabIndex = 2;
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
            this.chkAYear3.TabIndex = 1;
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
            this.chkAYear1.TabIndex = 0;
            this.chkAYear1.Text = "Year 1";
            this.chkAYear1.UseVisualStyleBackColor = true;
            // 
            // frmAddPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 350);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddPaper";
            this.Text = "Add Paper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreAdd;
        private System.Windows.Forms.Button btnPreRemove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}