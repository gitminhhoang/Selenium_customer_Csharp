namespace Selenium_custom.action
{
    partial class CheckingProfile
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
            this.btnCheckingCT = new System.Windows.Forms.Button();
            this.txtUidProfileCT = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckingCT
            // 
            this.btnCheckingCT.Location = new System.Drawing.Point(30, 101);
            this.btnCheckingCT.Name = "btnCheckingCT";
            this.btnCheckingCT.Size = new System.Drawing.Size(97, 27);
            this.btnCheckingCT.TabIndex = 6;
            this.btnCheckingCT.Text = "Checking profile";
            this.btnCheckingCT.UseVisualStyleBackColor = true;
            this.btnCheckingCT.Click += new System.EventHandler(this.btnCheckingCT_Click);
            // 
            // txtUidProfileCT
            // 
            this.txtUidProfileCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUidProfileCT.Location = new System.Drawing.Point(30, 51);
            this.txtUidProfileCT.Multiline = true;
            this.txtUidProfileCT.Name = "txtUidProfileCT";
            this.txtUidProfileCT.Size = new System.Drawing.Size(315, 35);
            this.txtUidProfileCT.TabIndex = 5;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(158, 106);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 15);
            this.lbStatus.TabIndex = 7;
            // 
            // CheckingProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCheckingCT);
            this.Controls.Add(this.txtUidProfileCT);
            this.Name = "CheckingProfile";
            this.Size = new System.Drawing.Size(400, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckingCT;
        private System.Windows.Forms.TextBox txtUidProfileCT;
        private System.Windows.Forms.Label lbStatus;
    }
}
