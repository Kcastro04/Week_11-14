namespace UserInstallationGuide
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label lblInfo;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Label lblReq;
        private System.Windows.Forms.Label lblInstall;
        private System.Windows.Forms.Label lblSetup;
        private System.Windows.Forms.Label lblTrouble;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.infoPanel = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();

            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();

            this.lblReq = new System.Windows.Forms.Label();
            this.lblInstall = new System.Windows.Forms.Label();
            this.lblSetup = new System.Windows.Forms.Label();
            this.lblTrouble = new System.Windows.Forms.Label();

            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            // Form

            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Text = "Week 14 - User Installation Guide";

            // topPanel

            this.topPanel.BackColor = System.Drawing.Color.FromArgb(25, 45, 100);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Size = new System.Drawing.Size(1200, 70);

            // lblTitle

            this.lblTitle.Text = "Week 14 – Lab Activity: User Installation Guide";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 18);
            this.lblTitle.AutoSize = true;

            this.topPanel.Controls.Add(this.lblTitle);

            // infoPanel

            this.infoPanel.BackColor = System.Drawing.Color.Honeydew;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoPanel.Location = new System.Drawing.Point(35, 90);
            this.infoPanel.Size = new System.Drawing.Size(1120, 70);

            // lblInfo

            this.lblInfo.Text = "A User Installation Guide helps end-users install and set up the application correctly.";
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.AutoSize = true;

            this.infoPanel.Controls.Add(this.lblInfo);

            // PANEL 1

            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(35, 190);
            this.panel1.Size = new System.Drawing.Size(250, 400);

            this.lblReq.Text = "01  System Requirements";
            this.lblReq.BackColor = System.Drawing.Color.ForestGreen;
            this.lblReq.ForeColor = System.Drawing.Color.White;
            this.lblReq.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReq.Location = new System.Drawing.Point(0, 0);
            this.lblReq.Size = new System.Drawing.Size(250, 45);

            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBox1.Location = new System.Drawing.Point(15, 70);
            this.listBox1.Size = new System.Drawing.Size(210, 250);

            this.listBox1.Items.Add("• OS: Windows 10 or later");
            this.listBox1.Items.Add("• .NET Framework 4.8");
            this.listBox1.Items.Add("• Minimum 4GB RAM");
            this.listBox1.Items.Add("• 50MB Free Disk Space");

            this.panel1.Controls.Add(this.lblReq);
            this.panel1.Controls.Add(this.listBox1);

            // PANEL 2

            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(320, 190);
            this.panel2.Size = new System.Drawing.Size(250, 400);

            this.lblInstall.Text = "02  Installation Steps";
            this.lblInstall.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblInstall.ForeColor = System.Drawing.Color.White;
            this.lblInstall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstall.Location = new System.Drawing.Point(0, 0);
            this.lblInstall.Size = new System.Drawing.Size(250, 45);

            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBox2.Location = new System.Drawing.Point(15, 70);
            this.listBox2.Size = new System.Drawing.Size(210, 250);

            this.listBox2.Items.Add("• Download installer (.exe)");
            this.listBox2.Items.Add("• Run as Administrator");
            this.listBox2.Items.Add("• Follow setup wizard");
            this.listBox2.Items.Add("• Accept license agreement");
            this.listBox2.Items.Add("• Choose install folder");
            this.listBox2.Items.Add("• Click Finish");

            this.panel2.Controls.Add(this.lblInstall);
            this.panel2.Controls.Add(this.listBox2);

            // PANEL 3

            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(605, 190);
            this.panel3.Size = new System.Drawing.Size(250, 400);

            this.lblSetup.Text = "03  First-Time Setup";
            this.lblSetup.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblSetup.ForeColor = System.Drawing.Color.White;
            this.lblSetup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSetup.Location = new System.Drawing.Point(0, 0);
            this.lblSetup.Size = new System.Drawing.Size(250, 45);

            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBox3.Location = new System.Drawing.Point(15, 70);
            this.listBox3.Size = new System.Drawing.Size(210, 250);

            this.listBox3.Items.Add("• Launch the application");
            this.listBox3.Items.Add("• Create admin account");
            this.listBox3.Items.Add("• Configure preferences");
            this.listBox3.Items.Add("• Complete setup tutorial");

            this.panel3.Controls.Add(this.lblSetup);
            this.panel3.Controls.Add(this.listBox3);

            // PANEL 4

            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(890, 190);
            this.panel4.Size = new System.Drawing.Size(250, 400);

            this.lblTrouble.Text = "04  Troubleshooting";
            this.lblTrouble.BackColor = System.Drawing.Color.Chocolate;
            this.lblTrouble.ForeColor = System.Drawing.Color.White;
            this.lblTrouble.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrouble.Location = new System.Drawing.Point(0, 0);
            this.lblTrouble.Size = new System.Drawing.Size(250, 45);

            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBox4.Location = new System.Drawing.Point(15, 70);
            this.listBox4.Size = new System.Drawing.Size(210, 250);

            this.listBox4.Items.Add("• Run as Administrator");
            this.listBox4.Items.Add("• Check antivirus exclusions");
            this.listBox4.Items.Add("• Reinstall .NET Framework");
            this.listBox4.Items.Add("• Contact support@app.com");

            this.panel4.Controls.Add(this.lblTrouble);
            this.panel4.Controls.Add(this.listBox4);

            // ADD CONTROLS

            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.infoPanel);

            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);

            this.ResumeLayout(false);
        }
    }
}
