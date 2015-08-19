namespace SoftwareProcess
{
    partial class frmStudentStudy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdminAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstPapers = new System.Windows.Forms.ListBox();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkWebDev = new System.Windows.Forms.CheckBox();
            this.chkSoftwareArch = new System.Windows.Forms.CheckBox();
            this.chkAnal = new System.Windows.Forms.CheckBox();
            this.chkNetwork = new System.Windows.Forms.CheckBox();
            this.chkDB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkYear2 = new System.Windows.Forms.CheckBox();
            this.chkYear3 = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCareerOpp = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblPrereq = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPaperDesc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPaperName = new System.Windows.Forms.Label();
            this.lstInfoPapers = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileLoad,
            this.mnuFileSave,
            this.toolStripSeparator2,
            this.mnuFilePrint,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileLoad
            // 
            this.mnuFileLoad.Name = "mnuFileLoad";
            this.mnuFileLoad.Size = new System.Drawing.Size(100, 22);
            this.mnuFileLoad.Text = "&Load";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(100, 22);
            this.mnuFileSave.Text = "&Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.Size = new System.Drawing.Size(100, 22);
            this.mnuFilePrint.Text = "&Print";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(100, 22);
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdminAdd,
            this.editPaperToolStripMenuItem});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "&Admin";
            // 
            // mnuAdminAdd
            // 
            this.mnuAdminAdd.Name = "mnuAdminAdd";
            this.mnuAdminAdd.Size = new System.Drawing.Size(175, 22);
            this.mnuAdminAdd.Text = "&Add Paper";
            this.mnuAdminAdd.Click += new System.EventHandler(this.mnuAdminAdd_Click);
            // 
            // editPaperToolStripMenuItem
            // 
            this.editPaperToolStripMenuItem.Name = "editPaperToolStripMenuItem";
            this.editPaperToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.editPaperToolStripMenuItem.Text = "&Edit/Remove Paper";
            this.editPaperToolStripMenuItem.Click += new System.EventHandler(this.editPaperToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(336, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 519);
            this.panel1.TabIndex = 1;
            // 
            // lstPapers
            // 
            this.lstPapers.FormattingEnabled = true;
            this.lstPapers.Location = new System.Drawing.Point(6, 183);
            this.lstPapers.Name = "lstPapers";
            this.lstPapers.Size = new System.Drawing.Size(157, 134);
            this.lstPapers.TabIndex = 2;
            this.lstPapers.TabStop = false;
            // 
            // lstSelected
            // 
            this.lstSelected.FormattingEnabled = true;
            this.lstSelected.Location = new System.Drawing.Point(169, 183);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(157, 342);
            this.lstSelected.TabIndex = 3;
            this.lstSelected.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.Location = new System.Drawing.Point(6, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRemove.Location = new System.Drawing.Point(6, 361);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(157, 28);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.Location = new System.Drawing.Point(6, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criteria";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkWebDev);
            this.groupBox3.Controls.Add(this.chkSoftwareArch);
            this.groupBox3.Controls.Add(this.chkAnal);
            this.groupBox3.Controls.Add(this.chkNetwork);
            this.groupBox3.Controls.Add(this.chkDB);
            this.groupBox3.Location = new System.Drawing.Point(6, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 90);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Specialization";
            // 
            // chkWebDev
            // 
            this.chkWebDev.AutoSize = true;
            this.chkWebDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWebDev.Location = new System.Drawing.Point(6, 42);
            this.chkWebDev.Name = "chkWebDev";
            this.chkWebDev.Size = new System.Drawing.Size(115, 17);
            this.chkWebDev.TabIndex = 4;
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
            this.chkSoftwareArch.TabIndex = 2;
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
            this.chkNetwork.TabIndex = 3;
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
            this.chkDB.TabIndex = 5;
            this.chkDB.Text = "Database Development";
            this.chkDB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkYear2);
            this.groupBox2.Controls.Add(this.chkYear3);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 47);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Years";
            // 
            // chkYear2
            // 
            this.chkYear2.AutoSize = true;
            this.chkYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYear2.Location = new System.Drawing.Point(6, 19);
            this.chkYear2.Name = "chkYear2";
            this.chkYear2.Size = new System.Drawing.Size(93, 17);
            this.chkYear2.TabIndex = 0;
            this.chkYear2.Text = "Year 2 Papers";
            this.chkYear2.UseVisualStyleBackColor = true;
            // 
            // chkYear3
            // 
            this.chkYear3.AutoSize = true;
            this.chkYear3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYear3.Location = new System.Drawing.Point(157, 19);
            this.chkYear3.Name = "chkYear3";
            this.chkYear3.Size = new System.Drawing.Size(93, 17);
            this.chkYear3.TabIndex = 1;
            this.chkYear3.Text = "Year 3 Papers";
            this.chkYear3.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.Location = new System.Drawing.Point(6, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLoad.Location = new System.Drawing.Point(6, 463);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(157, 28);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPrint.Location = new System.Drawing.Point(6, 497);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(157, 28);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 558);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage1.Controls.Add(this.lstSelected);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Controls.Add(this.lstPapers);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Study Plan";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.lstInfoPapers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paper Information";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.groupBox6);
            this.panel5.Location = new System.Drawing.Point(209, 416);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(584, 101);
            this.panel5.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCareerOpp);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(576, 93);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Future Career Oppourtunities";
            // 
            // lblCareerOpp
            // 
            this.lblCareerOpp.AutoSize = true;
            this.lblCareerOpp.Location = new System.Drawing.Point(7, 20);
            this.lblCareerOpp.Name = "lblCareerOpp";
            this.lblCareerOpp.Size = new System.Drawing.Size(35, 13);
            this.lblCareerOpp.TabIndex = 0;
            this.lblCareerOpp.Text = "label4";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.groupBox5);
            this.panel4.Location = new System.Drawing.Point(209, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 110);
            this.panel4.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblPrereq);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(576, 102);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prerequisites";
            // 
            // lblPrereq
            // 
            this.lblPrereq.AutoSize = true;
            this.lblPrereq.Location = new System.Drawing.Point(7, 20);
            this.lblPrereq.Name = "lblPrereq";
            this.lblPrereq.Size = new System.Drawing.Size(35, 13);
            this.lblPrereq.TabIndex = 0;
            this.lblPrereq.Text = "label3";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Location = new System.Drawing.Point(209, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 224);
            this.panel3.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPaperDesc);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(576, 216);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paper Description";
            // 
            // lblPaperDesc
            // 
            this.lblPaperDesc.AutoSize = true;
            this.lblPaperDesc.Location = new System.Drawing.Point(7, 20);
            this.lblPaperDesc.Name = "lblPaperDesc";
            this.lblPaperDesc.Size = new System.Drawing.Size(35, 13);
            this.lblPaperDesc.TabIndex = 0;
            this.lblPaperDesc.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPaperName);
            this.panel2.Location = new System.Drawing.Point(209, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 45);
            this.panel2.TabIndex = 1;
            // 
            // lblPaperName
            // 
            this.lblPaperName.AutoSize = true;
            this.lblPaperName.Location = new System.Drawing.Point(10, 13);
            this.lblPaperName.Name = "lblPaperName";
            this.lblPaperName.Size = new System.Drawing.Size(35, 13);
            this.lblPaperName.TabIndex = 0;
            this.lblPaperName.Text = "label1";
            // 
            // lstInfoPapers
            // 
            this.lstInfoPapers.FormattingEnabled = true;
            this.lstInfoPapers.Location = new System.Drawing.Point(8, 19);
            this.lstInfoPapers.Name = "lstInfoPapers";
            this.lstInfoPapers.Size = new System.Drawing.Size(193, 498);
            this.lstInfoPapers.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmStudentStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 604);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStudentStudy";
            this.Text = "Student Study Planner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstPapers;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkWebDev;
        private System.Windows.Forms.CheckBox chkSoftwareArch;
        private System.Windows.Forms.CheckBox chkAnal;
        private System.Windows.Forms.CheckBox chkNetwork;
        private System.Windows.Forms.CheckBox chkDB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkYear2;
        private System.Windows.Forms.CheckBox chkYear3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstInfoPapers;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mnuAdminAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblCareerOpp;
        private System.Windows.Forms.Label lblPrereq;
        private System.Windows.Forms.Label lblPaperDesc;
        private System.Windows.Forms.Label lblPaperName;
        private System.Windows.Forms.ToolStripMenuItem editPaperToolStripMenuItem;
    }
}

