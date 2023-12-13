using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web_Squirrel_Distributor.Configuration;
using Web_Squirrel_Distributor.Customization;

namespace Web_Squirrel_Distributor
{
    public partial class frmMenu : CustomForm
    {
        public frmMenu()
        {
            InitializeComponent();
            
            ConfigureFormProperties();
            ConfigureTextBoxProperties();

            ConfigureFormEvents();

        }
        private void btnRollback_Click(object sender, EventArgs e)
        {
            rollbackApplicationAsync();
        }
        private async void rollbackApplicationAsync()
        {            
            try
            {
                await WebUpdateSquirrel.rollbackAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /** Form Configuration **/
        private void ConfigureFormEvents()
        {
            this.Load += frmMenu_Load;
        }
        private void ConfigureFormProperties()
        {
            this.toDefaultForm();
        }
        private async void frmMenu_Load(object sender, EventArgs e)
        {

            /** Attributes **/
            ConfigureTextBoxAttributes();

            await WebUpdateSquirrel.CheckForUpdatesAsync();
            /** Events **/
            ConfigureButtonEvents();

        }

        /** Button Configuration **/
        private void ConfigureButtonEvents()
        {
            btnRollback.Click += btnRollback_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /** TextBox Configuration **/
        private void ConfigureTextBoxProperties()
        {
            txtProgramVersion.ReadOnly = true;
            txtProgramVersion.TabStop = false;
        }
        private void ConfigureTextBoxAttributes()
        {
            txtProgramVersion.Text = Application.ProductVersion;
        }
    }
}
