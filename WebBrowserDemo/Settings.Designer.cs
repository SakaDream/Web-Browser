namespace WebBrowserDemo
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panTBColor = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblUS = new System.Windows.Forms.Label();
            this.btnCTU = new System.Windows.Forms.Button();
            this.panBtn = new System.Windows.Forms.Panel();
            this.lblOptions = new System.Windows.Forms.Label();
            this.cBAutoCTU = new System.Windows.Forms.CheckBox();
            this.panBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(13, 13);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(79, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Home Address:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(110, 10);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(552, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(587, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toolbar Color:";
            // 
            // panTBColor
            // 
            this.panTBColor.Location = new System.Drawing.Point(110, 45);
            this.panTBColor.Name = "panTBColor";
            this.panTBColor.Size = new System.Drawing.Size(438, 20);
            this.panTBColor.TabIndex = 6;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(587, 44);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 13);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(13, 85);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(45, 13);
            this.lblUpdate.TabIndex = 9;
            this.lblUpdate.Text = "Update:";
            // 
            // lblUS
            // 
            this.lblUS.AutoSize = true;
            this.lblUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUS.Location = new System.Drawing.Point(107, 83);
            this.lblUS.Name = "lblUS";
            this.lblUS.Size = new System.Drawing.Size(0, 16);
            this.lblUS.TabIndex = 10;
            // 
            // btnCTU
            // 
            this.btnCTU.Location = new System.Drawing.Point(563, 80);
            this.btnCTU.Name = "btnCTU";
            this.btnCTU.Size = new System.Drawing.Size(99, 23);
            this.btnCTU.TabIndex = 11;
            this.btnCTU.Text = "Check to Update";
            this.btnCTU.UseVisualStyleBackColor = true;
            // 
            // panBtn
            // 
            this.panBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panBtn.Controls.Add(this.btnAbout);
            this.panBtn.Controls.Add(this.btnOK);
            this.panBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBtn.Location = new System.Drawing.Point(0, 153);
            this.panBtn.Name = "panBtn";
            this.panBtn.Size = new System.Drawing.Size(674, 48);
            this.panBtn.TabIndex = 12;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(15, 118);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(46, 13);
            this.lblOptions.TabIndex = 13;
            this.lblOptions.Text = "Options:";
            // 
            // cBAutoCTU
            // 
            this.cBAutoCTU.AutoSize = true;
            this.cBAutoCTU.Location = new System.Drawing.Point(110, 118);
            this.cBAutoCTU.Name = "cBAutoCTU";
            this.cBAutoCTU.Size = new System.Drawing.Size(277, 17);
            this.cBAutoCTU.TabIndex = 14;
            this.cBAutoCTU.Text = "Check to Update automatically when application start";
            this.cBAutoCTU.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 201);
            this.Controls.Add(this.cBAutoCTU);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.panBtn);
            this.Controls.Add(this.btnCTU);
            this.Controls.Add(this.lblUS);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.panTBColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Settings - Web Browser";
            this.panBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        public System.Windows.Forms.TextBox txtInput;
        public System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panTBColor;
        public System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblUpdate;
        public System.Windows.Forms.Label lblUS;
        public System.Windows.Forms.Button btnCTU;
        private System.Windows.Forms.Panel panBtn;
        private System.Windows.Forms.Label lblOptions;
        public System.Windows.Forms.CheckBox cBAutoCTU;
    }
}