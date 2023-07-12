namespace Selenium_custom.action
{
    partial class GetProfileByUid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetProfile = new System.Windows.Forms.Button();
            this.rtbInfor = new System.Windows.Forms.RichTextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetProfile
            // 
            this.btnGetProfile.Location = new System.Drawing.Point(30, 71);
            this.btnGetProfile.Name = "btnGetProfile";
            this.btnGetProfile.Size = new System.Drawing.Size(114, 23);
            this.btnGetProfile.TabIndex = 3;
            this.btnGetProfile.Text = "Get Profile";
            this.btnGetProfile.UseVisualStyleBackColor = true;
            this.btnGetProfile.Click += new System.EventHandler(this.btnGetProfile_Click);
            // 
            // rtbInfor
            // 
            this.rtbInfor.Location = new System.Drawing.Point(30, 109);
            this.rtbInfor.Name = "rtbInfor";
            this.rtbInfor.Size = new System.Drawing.Size(541, 307);
            this.rtbInfor.TabIndex = 2;
            this.rtbInfor.Text = "";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(30, 37);
            this.txtUid.Multiline = true;
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(216, 27);
            this.txtUid.TabIndex = 4;
            // 
            // GetProfileByUid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.btnGetProfile);
            this.Controls.Add(this.rtbInfor);
            this.Name = "GetProfileByUid";
            this.Size = new System.Drawing.Size(610, 428);
            this.Load += new System.EventHandler(this.GetProfileByUid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetProfile;
        private System.Windows.Forms.RichTextBox rtbInfor;
        private System.Windows.Forms.TextBox txtUid;
    }
}
