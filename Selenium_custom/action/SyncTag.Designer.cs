namespace Selenium_custom.action
{
    partial class SyncTag
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfileUid = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnSyncTags = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbTags = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Profile uid *";
            // 
            // txtProfileUid
            // 
            this.txtProfileUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileUid.Location = new System.Drawing.Point(30, 51);
            this.txtProfileUid.Multiline = true;
            this.txtProfileUid.Name = "txtProfileUid";
            this.txtProfileUid.Size = new System.Drawing.Size(315, 35);
            this.txtProfileUid.TabIndex = 18;
            this.txtProfileUid.Text = "999c182d-3c92-42b9-a0af-1b54febe3ce9";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(188, 217);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 15);
            this.lbStatus.TabIndex = 21;
            // 
            // btnSyncTags
            // 
            this.btnSyncTags.Location = new System.Drawing.Point(30, 212);
            this.btnSyncTags.Name = "btnSyncTags";
            this.btnSyncTags.Size = new System.Drawing.Size(140, 27);
            this.btnSyncTags.TabIndex = 20;
            this.btnSyncTags.Text = "Sync Tags";
            this.btnSyncTags.UseVisualStyleBackColor = true;
            this.btnSyncTags.Click += new System.EventHandler(this.btnSyncTags_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tags ( fb,amz )";
            // 
            // rtbTags
            // 
            this.rtbTags.Location = new System.Drawing.Point(30, 129);
            this.rtbTags.Name = "rtbTags";
            this.rtbTags.Size = new System.Drawing.Size(315, 62);
            this.rtbTags.TabIndex = 23;
            this.rtbTags.Text = "facebook,amazon";
            // 
            // SyncTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnSyncTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfileUid);
            this.Name = "SyncTag";
            this.Size = new System.Drawing.Size(444, 266);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfileUid;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnSyncTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbTags;
    }
}
