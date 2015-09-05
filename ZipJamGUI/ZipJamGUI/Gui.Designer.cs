namespace ZipJamGUI
{
    partial class Gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.Extract = new System.Windows.Forms.Button();
            this.archiveInput = new System.Windows.Forms.TextBox();
            this.extractInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSelect_1 = new System.Windows.Forms.Button();
            this.fileSelect_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.Location = new System.Drawing.Point(496, 36);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(75, 20);
            this.ArchiveButton.TabIndex = 0;
            this.ArchiveButton.Text = "Archive";
            this.ArchiveButton.UseVisualStyleBackColor = true;
            this.ArchiveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Extract
            // 
            this.Extract.Location = new System.Drawing.Point(496, 93);
            this.Extract.Name = "Extract";
            this.Extract.Size = new System.Drawing.Size(75, 20);
            this.Extract.TabIndex = 1;
            this.Extract.Text = "Extract";
            this.Extract.UseVisualStyleBackColor = true;
            this.Extract.Click += new System.EventHandler(this.Extract_Click);
            // 
            // archiveInput
            // 
            this.archiveInput.AllowDrop = true;
            this.archiveInput.Location = new System.Drawing.Point(24, 36);
            this.archiveInput.Name = "archiveInput";
            this.archiveInput.Size = new System.Drawing.Size(390, 20);
            this.archiveInput.TabIndex = 2;
            this.archiveInput.TextChanged += new System.EventHandler(this.archiveInput_TextChanged);
            // 
            // extractInput
            // 
            this.extractInput.Location = new System.Drawing.Point(24, 93);
            this.extractInput.Name = "extractInput";
            this.extractInput.Size = new System.Drawing.Size(390, 20);
            this.extractInput.TabIndex = 3;
            this.extractInput.TextChanged += new System.EventHandler(this.extractInput_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fileSelect_1
            // 
            this.fileSelect_1.Location = new System.Drawing.Point(420, 36);
            this.fileSelect_1.Name = "fileSelect_1";
            this.fileSelect_1.Size = new System.Drawing.Size(24, 20);
            this.fileSelect_1.TabIndex = 4;
            this.fileSelect_1.Text = "...";
            this.fileSelect_1.UseVisualStyleBackColor = true;
            this.fileSelect_1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fileSelect_2
            // 
            this.fileSelect_2.Location = new System.Drawing.Point(420, 93);
            this.fileSelect_2.Name = "fileSelect_2";
            this.fileSelect_2.Size = new System.Drawing.Size(24, 20);
            this.fileSelect_2.TabIndex = 5;
            this.fileSelect_2.Text = "...";
            this.fileSelect_2.UseVisualStyleBackColor = true;
            this.fileSelect_2.Click += new System.EventHandler(this.fileSelect_2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select File To Archive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select File To Extract";
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(606, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileSelect_2);
            this.Controls.Add(this.fileSelect_1);
            this.Controls.Add(this.extractInput);
            this.Controls.Add(this.archiveInput);
            this.Controls.Add(this.Extract);
            this.Controls.Add(this.ArchiveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gui";
            this.Text = "ZipJam";
            this.Load += new System.EventHandler(this.Gui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ArchiveButton;
        private System.Windows.Forms.Button Extract;
        private System.Windows.Forms.TextBox archiveInput;
        private System.Windows.Forms.TextBox extractInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fileSelect_1;
        private System.Windows.Forms.Button fileSelect_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

