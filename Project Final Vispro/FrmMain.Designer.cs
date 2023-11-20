namespace Project_Final_Vispro
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnbio = new System.Windows.Forms.Button();
            this.btnschedule = new System.Windows.Forms.Button();
            this.btngrade = new System.Windows.Forms.Button();
            this.btnabsent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbio
            // 
            this.btnbio.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnbio, "btnbio");
            this.btnbio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbio.ForeColor = System.Drawing.Color.Transparent;
            this.btnbio.Name = "btnbio";
            this.btnbio.UseVisualStyleBackColor = false;
            // 
            // btnschedule
            // 
            this.btnschedule.BackColor = System.Drawing.Color.Transparent;
            this.btnschedule.BackgroundImage = global::Project_Final_Vispro.Properties.Resources.calendar;
            resources.ApplyResources(this.btnschedule, "btnschedule");
            this.btnschedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnschedule.ForeColor = System.Drawing.Color.Transparent;
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.UseVisualStyleBackColor = false;
            // 
            // btngrade
            // 
            this.btngrade.BackColor = System.Drawing.Color.Transparent;
            this.btngrade.BackgroundImage = global::Project_Final_Vispro.Properties.Resources.exam;
            resources.ApplyResources(this.btngrade, "btngrade");
            this.btngrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngrade.ForeColor = System.Drawing.Color.Transparent;
            this.btngrade.Name = "btngrade";
            this.btngrade.UseVisualStyleBackColor = false;
            // 
            // btnabsent
            // 
            this.btnabsent.BackColor = System.Drawing.Color.Transparent;
            this.btnabsent.BackgroundImage = global::Project_Final_Vispro.Properties.Resources.absent__1_;
            resources.ApplyResources(this.btnabsent, "btnabsent");
            this.btnabsent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnabsent.ForeColor = System.Drawing.Color.Transparent;
            this.btnabsent.Name = "btnabsent";
            this.btnabsent.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::Project_Final_Vispro.Properties.Resources.adrian_infernus_GLf7bAwCdYg_unsplash;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnabsent);
            this.Controls.Add(this.btngrade);
            this.Controls.Add(this.btnschedule);
            this.Controls.Add(this.btnbio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbio;
        private System.Windows.Forms.Button btnschedule;
        private System.Windows.Forms.Button btngrade;
        private System.Windows.Forms.Button btnabsent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}