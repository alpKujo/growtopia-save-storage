using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveDatStore
{
    public partial class frmStorage : Form
    {
        public frmStorage()
        {
            InitializeComponent();
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            string growPath = SaveDatStore.Properties.Settings.Default.growLoc;
            string destPath = SaveDatStore.Properties.Settings.Default.storageLoc;
            
            if (string.IsNullOrEmpty(txtActivate.Text))
            {
                MessageBox.Show("You have to enter a GrowID!", "Activate Error");
            }
            else
            {
                if (File.Exists(growPath + "\\save.dat"))
                {
                    MessageBox.Show("There is already an active save!");
                }
                else
                {

                    if (File.Exists(destPath + "\\" + txtActivate.Text + ".dat"))
                    {
                        File.Copy(destPath + "\\" + txtActivate.Text + ".dat", growPath + "\\save.dat");
                        File.Delete(destPath + "\\" + txtActivate.Text + ".dat");

                        MessageBox.Show(txtActivate.Text + " successfully activated!", "Activate");

                        SaveDatStore.Properties.Settings.Default.growID = txtActivate.Text;

                    }
                    else
                    {
                        MessageBox.Show("There is no save named " + txtActivate.Text + ".dat!");
                    }
                }
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string destPath = SaveDatStore.Properties.Settings.Default.storageLoc;
                     
            var files = Directory.GetFiles(destPath, "*.dat", SearchOption.AllDirectories).Select(Path.GetFileNameWithoutExtension);
            string growIDs = string.Join("\n", files);

            MessageBox.Show(growIDs, "Storage");           
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            string growPath = SaveDatStore.Properties.Settings.Default.growLoc;
            string destPath = SaveDatStore.Properties.Settings.Default.storageLoc;
            string growID = SaveDatStore.Properties.Settings.Default.growID;

            DirectoryInfo storage = new DirectoryInfo(destPath);
            FileInfo[] DATFiles = storage.GetFiles("*.dat");

            if (DATFiles.Length == 0)
            {
                MessageBox.Show("The storage is currently empty.", "Empty Storage");
            }
            else
            {
                if (string.IsNullOrEmpty(txtGrowIDget.Text))
                {
                    MessageBox.Show("You have to enter a GrowID!", "Activate Error");
                }
                else
                {
                    if (File.Exists(destPath + "\\" + txtGrowIDget.Text + ".dat"))
                    {
                        if (File.Exists(growPath + "\\save.dat"))
                        {
                            File.Copy(growPath + "\\save.dat", destPath + "\\" + growID + ".dat");
                            File.Delete(growPath + "\\save.dat");

                            SaveDatStore.Properties.Settings.Default.growID = txtGrowIDget.Text;
                            SaveDatStore.Properties.Settings.Default.Save();

                            File.Copy(destPath + "\\" + txtGrowIDget.Text + ".dat", growPath + "\\save.dat");
                            File.Delete(destPath + "\\" + txtGrowIDget.Text + ".dat");
                            MessageBox.Show(txtGrowIDget.Text + " and " + growID + " successfully swapped!", "Swap");
                        }
                        else
                        {
                            MessageBox.Show("There is no save.dat to be swapped with!");
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("There is no save with the name " + txtGrowIDget.Text + ".dat!");
                    }                    
                }               
            }
        }
    }
}
