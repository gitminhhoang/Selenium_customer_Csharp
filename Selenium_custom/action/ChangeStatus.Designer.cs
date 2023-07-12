namespace Selenium_custom.action
{
    partial class ChangeStatus
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnSyncTags = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfileUid = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "id";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(191, 206);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 15);
            this.lbStatus.TabIndex = 27;
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // btnSyncTags
            // 
            this.btnSyncTags.Location = new System.Drawing.Point(30, 200);
            this.btnSyncTags.Name = "btnSyncTags";
            this.btnSyncTags.Size = new System.Drawing.Size(140, 27);
            this.btnSyncTags.TabIndex = 26;
            this.btnSyncTags.Text = "Change status";
            this.btnSyncTags.UseVisualStyleBackColor = true;
            this.btnSyncTags.Click += new System.EventHandler(this.btnSyncTags_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Profile uid *";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProfileUid
            // 
            this.txtProfileUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileUid.Location = new System.Drawing.Point(30, 55);
            this.txtProfileUid.Multiline = true;
            this.txtProfileUid.Name = "txtProfileUid";
            this.txtProfileUid.Size = new System.Drawing.Size(315, 35);
            this.txtProfileUid.TabIndex = 24;
            this.txtProfileUid.Text = "999c182d-3c92-42b9-a0af-1b54febe3ce9";
            this.txtProfileUid.TextChanged += new System.EventHandler(this.txtProfileUid_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(30, 134);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(315, 35);
            this.txtId.TabIndex = 29;
            this.txtId.Text = "63";
            // 
            // ChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnSyncTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfileUid);
            this.Name = "ChangeStatus";
            this.Size = new System.Drawing.Size(409, 275);
            this.Load += new System.EventHandler(this.ChangeStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnSyncTags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfileUid;
        private System.Windows.Forms.TextBox txtId;
    }
}
