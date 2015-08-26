namespace SoftwareProcess
{
    partial class frmRemovePaper
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
            this.lstERPapers = new System.Windows.Forms.ListBox();
            this.btnEREdit = new System.Windows.Forms.Button();
            this.btnERRemove = new System.Windows.Forms.Button();
            this.btnERCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstERPapers
            // 
            this.lstERPapers.FormattingEnabled = true;
            this.lstERPapers.Location = new System.Drawing.Point(12, 25);
            this.lstERPapers.Name = "lstERPapers";
            this.lstERPapers.Size = new System.Drawing.Size(223, 316);
            this.lstERPapers.TabIndex = 0;
            // 
            // btnEREdit
            // 
            this.btnEREdit.Location = new System.Drawing.Point(12, 347);
            this.btnEREdit.Name = "btnEREdit";
            this.btnEREdit.Size = new System.Drawing.Size(106, 23);
            this.btnEREdit.TabIndex = 1;
            this.btnEREdit.Text = "Edit";
            this.btnEREdit.UseVisualStyleBackColor = true;
            // 
            // btnERRemove
            // 
            this.btnERRemove.Location = new System.Drawing.Point(129, 347);
            this.btnERRemove.Name = "btnERRemove";
            this.btnERRemove.Size = new System.Drawing.Size(106, 23);
            this.btnERRemove.TabIndex = 2;
            this.btnERRemove.Text = "Archive";
            this.btnERRemove.UseVisualStyleBackColor = true;
            // 
            // btnERCancel
            // 
            this.btnERCancel.Location = new System.Drawing.Point(12, 376);
            this.btnERCancel.Name = "btnERCancel";
            this.btnERCancel.Size = new System.Drawing.Size(223, 23);
            this.btnERCancel.TabIndex = 3;
            this.btnERCancel.Text = "Cancel";
            this.btnERCancel.UseVisualStyleBackColor = true;
            this.btnERCancel.Click += new System.EventHandler(this.btnERCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a paper:";
            // 
            // frmRemovePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnERCancel);
            this.Controls.Add(this.btnERRemove);
            this.Controls.Add(this.btnEREdit);
            this.Controls.Add(this.lstERPapers);
            this.Name = "frmRemovePaper";
            this.Text = "Edit/Remove Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstERPapers;
        private System.Windows.Forms.Button btnEREdit;
        private System.Windows.Forms.Button btnERRemove;
        private System.Windows.Forms.Button btnERCancel;
        private System.Windows.Forms.Label label1;
    }
}