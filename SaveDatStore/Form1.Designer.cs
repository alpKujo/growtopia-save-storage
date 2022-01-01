namespace SaveDatStore
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActiveSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnActiveSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStorage);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 350);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(10, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "made by alpKujo\r\n";
            // 
            // btnActiveSave
            // 
            this.btnActiveSave.FlatAppearance.BorderSize = 0;
            this.btnActiveSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiveSave.ForeColor = System.Drawing.Color.Silver;
            this.btnActiveSave.Location = new System.Drawing.Point(0, 96);
            this.btnActiveSave.Name = "btnActiveSave";
            this.btnActiveSave.Size = new System.Drawing.Size(200, 38);
            this.btnActiveSave.TabIndex = 4;
            this.btnActiveSave.Text = "Save";
            this.btnActiveSave.UseVisualStyleBackColor = true;
            this.btnActiveSave.Click += new System.EventHandler(this.BtnActiveSave_Click);
            this.btnActiveSave.Leave += new System.EventHandler(this.BtnActiveSave_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "Growtopia\r\nSave Storage\r\n";
            // 
            // btnStorage
            // 
            this.btnStorage.FlatAppearance.BorderSize = 0;
            this.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.ForeColor = System.Drawing.Color.Silver;
            this.btnStorage.Location = new System.Drawing.Point(0, 137);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(200, 38);
            this.btnStorage.TabIndex = 1;
            this.btnStorage.Text = "Storage";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.BtnStorage_Click);
            this.btnStorage.Leave += new System.EventHandler(this.BtnStorage_Leave);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Silver;
            this.btnSettings.Location = new System.Drawing.Point(0, 178);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 38);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnGrowLocation_Click);
            this.btnSettings.Leave += new System.EventHandler(this.BtnGrowLocation_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 20);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PnlFormLoader.Location = new System.Drawing.Point(200, 50);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(400, 300);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label.Location = new System.Drawing.Point(206, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 28);
            this.label.TabIndex = 5;
            this.label.Text = "Settings";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(572, -5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActiveSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}

