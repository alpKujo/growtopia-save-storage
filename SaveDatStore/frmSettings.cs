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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtGrowPath.Text = SaveDatStore.Properties.Settings.Default.growLoc;
            txtStoragePath.Text = SaveDatStore.Properties.Settings.Default.storageLoc;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDatStore.Properties.Settings.Default.growLoc = txtGrowPath.Text;
            SaveDatStore.Properties.Settings.Default.storageLoc = txtStoragePath.Text;
            SaveDatStore.Properties.Settings.Default.Save();
            MessageBox.Show("Successfully Saved", "Save");
        }
        
    }
}