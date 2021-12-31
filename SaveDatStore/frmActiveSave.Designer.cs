namespace SaveDatStore
{
    partial class frmActiveSave
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoveSave = new System.Windows.Forms.Button();
            this.txtGrowID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 130);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clicking this button will move\r\nthe current save.dat file to the\r\nStorage, allowi" +
    "ng you to create\r\nanother one, without the first\r\none being deleted.";
            // 
            // btnMoveSave
            // 
            this.btnMoveSave.BackColor = System.Drawing.Color.DimGray;
            this.btnMoveSave.FlatAppearance.BorderSize = 0;
            this.btnMoveSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveSave.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveSave.ForeColor = System.Drawing.Color.Silver;
            this.btnMoveSave.Location = new System.Drawing.Point(17, 255);
            this.btnMoveSave.Name = "btnMoveSave";
            this.btnMoveSave.Size = new System.Drawing.Size(165, 33);
            this.btnMoveSave.TabIndex = 7;
            this.btnMoveSave.Text = "Store save.dat";
            this.btnMoveSave.UseVisualStyleBackColor = false;
            this.btnMoveSave.Click += new System.EventHandler(this.BtnMoveSave_Click);
            // 
            // txtGrowID
            // 
            this.txtGrowID.BackColor = System.Drawing.Color.DimGray;
            this.txtGrowID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrowID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrowID.ForeColor = System.Drawing.Color.Silver;
            this.txtGrowID.Location = new System.Drawing.Point(17, 64);
            this.txtGrowID.Name = "txtGrowID";
            this.txtGrowID.Size = new System.Drawing.Size(165, 33);
            this.txtGrowID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter your GrowID to identify\r\nthis save.dat file.";
            // 
            // frmActiveSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrowID);
            this.Controls.Add(this.btnMoveSave);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActiveSave";
            this.Text = "frmActiveSave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoveSave;
        private System.Windows.Forms.TextBox txtGrowID;
        private System.Windows.Forms.Label label1;
    }
}