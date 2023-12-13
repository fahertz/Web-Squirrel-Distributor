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
        public frmUpdateScreen()
        {
            InitializeComponent();            
            ConfigureFormProperties();
            ConfigureFormEvents();            
        }        

        /** Async Taks  **/
        private async Task updateApplicationAsync()
        {
            try
            {

                
                var d = await WebUpdateSquirrel.CheckForUpdatesAsync();
                if (d != null)
                {
                    lblSearchingForUpdates.Text = d;
                    UpdateUIForSearchingUpdates();
                    UpdateUIForDownloadComplete();
                    var d2 = await WebUpdateSquirrel.UpdateAppAsync();
                    lblDownload.Text = d2;

                    if (d2.Contains("Actualized"))
                    {
                        WebUpdateSquirrel.RestartApplication();
                    }
                    else
                    {
                        this.Hide();
                        frmMenu frmMenu = new frmMenu();
                        frmMenu.Show();
                    }
                }
                else
                {
                    UpdateUIForSearchingUpdates();
                    lblSearchingForUpdates.Text = "Doesn't exists new releases";
                    UpdateUIForDownloadComplete();
                    lblDownload.Text = "Doesn't exists releases to download";
                    Thread.Sleep(1000);
                    this.Hide();
                    frmMenu frmMenu = new frmMenu();
                    frmMenu.Show();


                }
            }
            catch (Exception ex)
            {
                // Log the exception or show a message to the user
                Console.WriteLine($"Error during update: {ex.Message}");
            }
            finally
            {
                //await Task.Delay(5000);
                //LocalUpdateSquirrel.RestartApplication();
            }
        }

        /** Sync Methods **/
        private void UpdateUIForSearchingUpdates()
        {
            //lblSearchingForUpdates.Text = $"Version: {LocalUpdateSquirrel.nextVersion} detected. ({Application.ProductVersion} → {LocalUpdateSquirrel.nextVersion})";
            UpdateButtonStyle(pcbSearchingForUpdates);
        }
        private void UpdateUIForDownloadComplete()
        {
            //lblDownload.Text = "Download Completed.";
            UpdateButtonStyle(pcbDownload);
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
            ConfigurePictureBoxAttributes();
            await updateApplicationAsync();

        }

        /** PictureBox Configuration **/
        private void ConfigurePictureBoxAttributes()
        {
            pcbSearchingForUpdates.BackgroundImage = Properties.Resources.Red_Button;
            pcbSearchingForUpdates.BackgroundImageLayout = ImageLayout.Stretch;
            pcbDownload.BackgroundImage = Properties.Resources.Red_Button;
            pcbDownload.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
