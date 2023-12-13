namespace Web_Squirrel_Distributor.App
{
    partial class frmUpdateScreen
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
            this.lblUpdatingApplication = new System.Windows.Forms.Label();
            this.pcbUpdatingApplication = new System.Windows.Forms.PictureBox();
            this.lblSearchingForUpdates = new System.Windows.Forms.Label();
            this.pcbSearchingForUpdates = new System.Windows.Forms.PictureBox();
            this.lblOpenning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpdatingApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchingForUpdates)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdatingApplication
            // 
            this.lblUpdatingApplication.AutoSize = true;
            this.lblUpdatingApplication.Location = new System.Drawing.Point(38, 58);
            this.lblUpdatingApplication.Name = "lblUpdatingApplication";
            this.lblUpdatingApplication.Size = new System.Drawing.Size(122, 13);
            this.lblUpdatingApplication.TabIndex = 11;
            this.lblUpdatingApplication.Text = "Actualizing Application...";
            // 
            // pcbUpdatingApplication
            // 
            this.pcbUpdatingApplication.Location = new System.Drawing.Point(12, 54);
            this.pcbUpdatingApplication.Name = "pcbUpdatingApplication";
            this.pcbUpdatingApplication.Size = new System.Drawing.Size(20, 20);
            this.pcbUpdatingApplication.TabIndex = 10;
            this.pcbUpdatingApplication.TabStop = false;
            // 
            // lblSearchingForUpdates
            // 
            this.lblSearchingForUpdates.AutoSize = true;
            this.lblSearchingForUpdates.Location = new System.Drawing.Point(38, 32);
            this.lblSearchingForUpdates.Name = "lblSearchingForUpdates";
            this.lblSearchingForUpdates.Size = new System.Drawing.Size(122, 13);
            this.lblSearchingForUpdates.TabIndex = 9;
            this.lblSearchingForUpdates.Text = "Searching for Updates...";
            // 
            // pcbSearchingForUpdates
            // 
            this.pcbSearchingForUpdates.Location = new System.Drawing.Point(12, 28);
            this.pcbSearchingForUpdates.Name = "pcbSearchingForUpdates";
            this.pcbSearchingForUpdates.Size = new System.Drawing.Size(20, 20);
            this.pcbSearchingForUpdates.TabIndex = 8;
            this.pcbSearchingForUpdates.TabStop = false;
            // 
            // lblOpenning
            // 
            this.lblOpenning.AutoSize = true;
            this.lblOpenning.Location = new System.Drawing.Point(146, 89);
            this.lblOpenning.Name = "lblOpenning";
            this.lblOpenning.Size = new System.Drawing.Size(62, 13);
            this.lblOpenning.TabIndex = 12;
            this.lblOpenning.Text = "Openning...";
            // 
            // frmUpdateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 111);
            this.Controls.Add(this.lblOpenning);
            this.Controls.Add(this.lblUpdatingApplication);
            this.Controls.Add(this.pcbUpdatingApplication);
            this.Controls.Add(this.lblSearchingForUpdates);
            this.Controls.Add(this.pcbSearchingForUpdates);
            this.Name = "frmUpdateScreen";
            this.Text = "Update Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpdatingApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchingForUpdates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUpdatingApplication;
        private System.Windows.Forms.PictureBox pcbUpdatingApplication;
        private System.Windows.Forms.Label lblSearchingForUpdates;
        private System.Windows.Forms.PictureBox pcbSearchingForUpdates;
        private System.Windows.Forms.Label lblOpenning;
    }
}