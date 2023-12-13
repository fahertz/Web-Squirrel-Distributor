using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web_Squirrel_Distributor.Configuration;
using Web_Squirrel_Distributor.Customization;

namespace Web_Squirrel_Distributor.App
{
    public partial class frmUpdateScreen : CustomForm
    {
        /** Instance **/
        System.Windows.Forms.Timer tUpdate = new System.Windows.Forms.Timer(); //Just for visual
        bool verified = false;
        bool updated = false;
        bool newVersion = false;
        public frmUpdateScreen()
        {
            InitializeComponent();            
            ConfigureFormProperties();
            ConfigureLabelProperties();
            ConfigureFormEvents();
            
        }
        
        /** Async Taks  **/
        private async Task updateApplicationAsync()
        {
            try
            {   
                var version = await WebUpdateSquirrel.CheckVersionAsync();                
                if (version == Application.ProductVersion)
                {
                    UpdateUIForSearchingUpdates();
                    UpdateUIForUpdateComplete();
                    lblSearchingForUpdates.Text = "Without new versions.";
                    lblUpdatingApplication.Text = "Without new versions.";
                    return;
                }


                var update = await WebUpdateSquirrel.CheckForUpdatesAsync();
                lblSearchingForUpdates.Text = update;

                
                if (update.Contains("detected"))
                {    
                    UpdateUIForSearchingUpdates();
                    lblSearchingForUpdates.Text = update;
                    lblUpdatingApplication.Text = "Updating Application...";
                    try
                    {                        
                        var att = await WebUpdateSquirrel.UpdateAppAsync();
                        lblUpdatingApplication.Text = att;
                        UpdateUIForUpdateComplete();
                        newVersion = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update error, please call the support: "+ex.Message);
                    }                    
                }
                else
                {
                    UpdateUIForSearchingUpdates();
                    UpdateUIForUpdateComplete();
                    lblSearchingForUpdates.Text = "Without new versions.";
                    lblUpdatingApplication.Text = "Without new versions.";
                    
                }

            }
            catch (Exception ex)
            {
                // Log the exception or show a message to the user
                Console.WriteLine($"Error during update: {ex.Message}");
            }
            finally
            {
                lblOpenning.Visible = true;
            }
        }


        /** Sync Methods **/
        private void UpdateUIForSearchingUpdates()
        {            
            UpdateButtonStyle(pcbSearchingForUpdates);
            verified = true;
        }
        private void UpdateUIForUpdateComplete()
        {
            
            UpdateButtonStyle(pcbUpdatingApplication);
            updated = true;
        }       
        private void UpdateButtonStyle(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Properties.Resources.Green_Button;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }



        /** Form Configuration **/
        private void ConfigureFormEvents()
        {
            this.Load += frmUpdateScreen_Load;
        }
        private void ConfigureFormProperties()
        {
            //this.toDefaultForm();
        }
        private async void frmUpdateScreen_Load(object sender, EventArgs e)
        {
            /** Attributes **/
            ConfigurePictureBoxAttributes();
            ConfigureLabelAttributes();
            ConfigureTimerAttributes();
            

            /** Events **/
            ConfigureTimerEvents();


            /** Searching for Updates**/
            await updateApplicationAsync();

            tUpdate.Start();

        }

        /** Timer Configuration **/
        private void ConfigureTimerAttributes()
        {
            tUpdate.Interval = 2000;
        }
        private void ConfigureTimerEvents()
        {
            tUpdate.Tick += tUpdate_Tick;
        }

        private void tUpdate_Tick(object sender, EventArgs e)
        {
            if (verified && updated && !newVersion)
            {

                frmMenu frmMenu = new frmMenu();
                this.Hide();
                tUpdate.Stop();
                frmMenu.Show();                                
            }
            else if (verified && updated && newVersion)
            {
                WebUpdateSquirrel.RestartApplication();
            }
            
        }

        /** PictureBox Configuration **/
        private void ConfigurePictureBoxAttributes()
        {
            pcbSearchingForUpdates.BackgroundImage = Properties.Resources.Red_Button;
            pcbSearchingForUpdates.BackgroundImageLayout = ImageLayout.Stretch;
            pcbUpdatingApplication.BackgroundImage = Properties.Resources.Red_Button;
            pcbUpdatingApplication.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /** Label Attributes **/
        private void ConfigureLabelAttributes()
        {
            lblSearchingForUpdates.Text = "Searching for Updates...";
            lblUpdatingApplication.Text = "Waiting...";
        }

        private void ConfigureLabelProperties()
        {
            lblOpenning.Visible = false;
        }
    }
}
