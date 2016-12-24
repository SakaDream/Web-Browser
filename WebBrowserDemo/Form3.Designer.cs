namespace WebBrowserDemo
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblName = new System.Windows.Forms.Label();
            this.lblPowered = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnWN = new System.Windows.Forms.Button();
            this.lblIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(62, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(207, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Web Browser (Beta)";
            // 
            // lblPowered
            // 
            this.lblPowered.AutoSize = true;
            this.lblPowered.Location = new System.Drawing.Point(109, 43);
            this.lblPowered.Name = "lblPowered";
            this.lblPowered.Size = new System.Drawing.Size(112, 13);
            this.lblPowered.TabIndex = 2;
            this.lblPowered.Text = "Powered by Chromium";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAuthor.Location = new System.Drawing.Point(49, 116);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(179, 16);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Copyright 2016 - SakaDream";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVersion.Location = new System.Drawing.Point(92, 86);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(93, 16);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version: x.x.x.x";
            // 
            // btnWN
            // 
            this.btnWN.Location = new System.Drawing.Point(96, 157);
            this.btnWN.Name = "btnWN";
            this.btnWN.Size = new System.Drawing.Size(84, 23);
            this.btnWN.TabIndex = 5;
            this.btnWN.Text = "What\'s New?";
            this.btnWN.UseVisualStyleBackColor = true;
            this.btnWN.Click += new System.EventHandler(this.btnWN_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.Image = global::WebBrowserDemo.Properties.Resources.web_browser;
            this.lblIcon.Location = new System.Drawing.Point(12, 13);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(44, 44);
            this.lblIcon.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 195);
            this.Controls.Add(this.btnWN);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblPowered);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "About - Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPowered;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.Button btnWN;
    }
}