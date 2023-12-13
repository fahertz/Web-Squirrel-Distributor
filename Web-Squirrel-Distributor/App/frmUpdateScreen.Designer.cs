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
            this.lblDownload = new System.Windows.Forms.Label();
            this.pcbDownload = new System.Windows.Forms.PictureBox();
            this.lblSearchingForUpdates = new System.Windows.Forms.Label();
            this.pcbSearchingForUpdates = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchingForUpdates)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(38, 58);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(122, 13);
            this.lblDownload.TabIndex = 11;
            this.lblDownload.Text = "Actualizing Application...";
            // 
            // pcbDownload
            // 
            this.pcbDownload.Location = new System.Drawing.Point(12, 54);
            this.pcbDownload.Name = "pcbDownload";
            this.pcbDownload.Size = new System.Drawing.Size(20, 20);
            this.pcbDownload.TabIndex = 10;
            this.pcbDownload.TabStop = false;
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
            // frmUpdateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 111);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.pcbDownload);
            this.Controls.Add(this.lblSearchingForUpdates);
            this.Controls.Add(this.pcbSearchingForUpdates);
            this.Name = "frmUpdateScreen";
            this.Text = "Update Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pcbDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchingForUpdates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.PictureBox pcbDownload;
        private System.Windows.Forms.Label lblSearchingForUpdates;
        private System.Windows.Forms.PictureBox pcbSearchingForUpdates;
    }
}