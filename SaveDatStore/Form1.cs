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
using System.Runtime.InteropServices;

namespace SaveDatStore
{
    public partial class Form1 : Form
    {
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            btnSettings.BackColor = Color.FromArgb(64, 64, 64);

            label.Text = "Have fun";            
        }

        private void BtnActiveSave_Click(object sender, EventArgs e)
        {
            btnActiveSave.BackColor = Color.FromArgb(128, 128, 128);

            label.Text = "Active Save";
            this.PnlFormLoader.Controls.Clear();
            frmActiveSave frmGrowLocation_Vrb = new frmActiveSave() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGrowLocation_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmGrowLocation_Vrb);
            frmGrowLocation_Vrb.Show();
        }

        private void BtnGrowLocation_Click(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(128, 128, 128);

            label.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            frmSettings frmGrowLocation_Vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGrowLocation_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmGrowLocation_Vrb);
            frmGrowLocation_Vrb.Show();            
        }

        private void BtnStorage_Click(object sender, EventArgs e)
        {
            btnStorage.BackColor = Color.FromArgb(128, 128, 128);

            label.Text = "Storage";
            this.PnlFormLoader.Controls.Clear();
            frmStorage frmGrowLocation_Vrb = new frmStorage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmGrowLocation_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmGrowLocation_Vrb);
            frmGrowLocation_Vrb.Show();
        }

        private void BtnActiveSave_Leave(object sender, EventArgs e)
        {
            btnActiveSave.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnGrowLocation_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnStorage_Leave(object sender, EventArgs e)
        {
            btnStorage.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }
}
