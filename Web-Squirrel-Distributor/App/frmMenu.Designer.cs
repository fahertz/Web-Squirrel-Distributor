namespace Web_Squirrel_Distributor
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.txtProgramVersion = new System.Windows.Forms.TextBox();
            this.lblProgramVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(371, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRollback
            // 
            this.btnRollback.Location = new System.Drawing.Point(158, 59);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(130, 46);
            this.btnRollback.TabIndex = 6;
            this.btnRollback.Text = "Rollback Version";
            this.btnRollback.UseVisualStyleBackColor = true;
            // 
            // txtProgramVersion
            // 
            this.txtProgramVersion.Location = new System.Drawing.Point(161, 33);
            this.txtProgramVersion.Name = "txtProgramVersion";
            this.txtProgramVersion.Size = new System.Drawing.Size(127, 20);
            this.txtProgramVersion.TabIndex = 5;
            // 
            // lblProgramVersion
            // 
            this.lblProgramVersion.AutoSize = true;
            this.lblProgramVersion.Location = new System.Drawing.Point(177, 17);
            this.lblProgramVersion.Name = "lblProgramVersion";
            this.lblProgramVersion.Size = new System.Drawing.Size(84, 13);
            this.lblProgramVersion.TabIndex = 4;
            this.lblProgramVersion.Text = "Program Version";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 114);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRollback);
            this.Controls.Add(this.txtProgramVersion);
            this.Controls.Add(this.lblProgramVersion);
            this.Name = "frmMenu";
            this.Text = "Web Squirrel Distributor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.TextBox txtProgramVersion;
        private System.Windows.Forms.Label lblProgramVersion;
    }
}

