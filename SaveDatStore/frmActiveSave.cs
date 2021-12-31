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
    public partial class frmActiveSave : Form
    {

        public frmActiveSave()
        {
            InitializeComponent();
        }

        private void BtnMoveSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGrowID.Text))
            {
                MessageBox.Show("You have to enter a GrowID", "Store Error");
            }
            else
            {
                string growPath = SaveDatStore.Properties.Settings.Default.growLoc;
                string destPath = SaveDatStore.Properties.Settings.Default.storageLoc;

                if (File.Exists(destPath + "\\" + txtGrowID.Text + ".dat"))
                {
                    MessageBox.Show("There is already a save named " + txtGrowID.Text + "!");
                }
                else
                {
                    //if (fileCount < 4)
                    //{
                    if (File.Exists(growPath + "\\save.dat"))
                    {
                        File.Copy(growPath + "\\save.dat", destPath + "\\" + txtGrowID.Text + ".dat");
                        File.Delete(growPath + "\\save.dat");
                        MessageBox.Show("Successfully stored as " + txtGrowID.Text + ".dat");
                    }
                    else
                    {
                        MessageBox.Show("Missing save.dat file in source folder", "Store Error");
                    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("There are already 3 files in the Storage", "Store Error");
                    //}
                }

            }

        }

    }
}
