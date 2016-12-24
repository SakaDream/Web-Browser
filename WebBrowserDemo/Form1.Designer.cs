namespace WebBrowserDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolBar = new System.Windows.Forms.Panel();
            this.btnNT = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.bwDownloading = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tc = new System.Windows.Forms.TabControl();
            this.btnCT = new System.Windows.Forms.Button();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.SystemColors.Control;
            this.ToolBar.Controls.Add(this.btnCT);
            this.ToolBar.Controls.Add(this.btnNT);
            this.ToolBar.Controls.Add(this.btnForward);
            this.ToolBar.Controls.Add(this.btnBack);
            this.ToolBar.Controls.Add(this.txtA);
            this.ToolBar.Controls.Add(this.btnS);
            this.ToolBar.Controls.Add(this.btnH);
            this.ToolBar.Controls.Add(this.btnR);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(1264, 52);
            this.ToolBar.TabIndex = 6;
            // 
            // btnNT
            // 
            this.btnNT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNT.AutoSize = true;
            this.btnNT.FlatAppearance.BorderSize = 0;
            this.btnNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNT.Image = global::WebBrowserDemo.Properties.Resources.new_tab;
            this.btnNT.Location = new System.Drawing.Point(1121, 5);
            this.btnNT.Name = "btnNT";
            this.btnNT.Size = new System.Drawing.Size(40, 40);
            this.btnNT.TabIndex = 12;
            this.btnNT.UseVisualStyleBackColor = true;
            this.btnNT.Click += new System.EventHandler(this.btnNT_Click);
            // 
            // btnForward
            // 
            this.btnForward.AutoSize = true;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Image = global::WebBrowserDemo.Properties.Resources.forward;
            this.btnForward.Location = new System.Drawing.Point(58, 7);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(38, 38);
            this.btnForward.TabIndex = 11;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::WebBrowserDemo.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(13, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 38);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtA
            // 
            this.txtA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtA.Location = new System.Drawing.Point(197, 14);
            this.txtA.MaximumSize = new System.Drawing.Size(1400, 25);
            this.txtA.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(918, 25);
            this.txtA.TabIndex = 6;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // btnS
            // 
            this.btnS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnS.AutoSize = true;
            this.btnS.FlatAppearance.BorderSize = 0;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Image = global::WebBrowserDemo.Properties.Resources.settings;
            this.btnS.Location = new System.Drawing.Point(1218, 6);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(40, 40);
            this.btnS.TabIndex = 9;
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnH
            // 
            this.btnH.AutoSize = true;
            this.btnH.FlatAppearance.BorderSize = 0;
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnH.Image = global::WebBrowserDemo.Properties.Resources.home;
            this.btnH.Location = new System.Drawing.Point(146, 6);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(40, 40);
            this.btnH.TabIndex = 8;
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnR
            // 
            this.btnR.AutoSize = true;
            this.btnR.FlatAppearance.BorderSize = 0;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Image = global::WebBrowserDemo.Properties.Resources.refresh;
            this.btnR.Location = new System.Drawing.Point(102, 7);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(38, 38);
            this.btnR.TabIndex = 7;
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // bwDownloading
            // 
            this.bwDownloading.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDownloading_DoWork);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tc
            // 
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 52);
            this.tc.Margin = new System.Windows.Forms.Padding(0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1264, 709);
            this.tc.TabIndex = 10;
            this.tc.SelectedIndexChanged += new System.EventHandler(this.tc_SelectedIndexChanged);
            // 
            // btnCT
            // 
            this.btnCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCT.AutoSize = true;
            this.btnCT.FlatAppearance.BorderSize = 0;
            this.btnCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCT.Image = global::WebBrowserDemo.Properties.Resources.close_tab;
            this.btnCT.Location = new System.Drawing.Point(1171, 6);
            this.btnCT.Name = "btnCT";
            this.btnCT.Size = new System.Drawing.Size(38, 38);
            this.btnCT.TabIndex = 13;
            this.btnCT.UseVisualStyleBackColor = true;
            this.btnCT.Click += new System.EventHandler(this.btnCT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.ToolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.ComponentModel.BackgroundWorker bwDownloading;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.Button btnNT;
        private System.Windows.Forms.Button btnCT;
    }
}

