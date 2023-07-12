namespace Selenium_custom.action
{
    partial class CloseProfile
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
            this.btnCloseCT = new System.Windows.Forms.Button();
            this.txtUidProfileCT = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseCT
            // 
            this.btnCloseCT.Location = new System.Drawing.Point(30, 101);
            this.btnCloseCT.Name = "btnCloseCT";
            this.btnCloseCT.Size = new System.Drawing.Size(97, 27);
            this.btnCloseCT.TabIndex = 3;
            this.btnCloseCT.Text = "Close profile";
            this.btnCloseCT.UseVisualStyleBackColor = true;
            this.btnCloseCT.Click += new System.EventHandler(this.btnCloseCT_Click);
            // 
            // txtUidProfileCT
            // 
            this.txtUidProfileCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUidProfileCT.Location = new System.Drawing.Point(30, 51);
            this.txtUidProfileCT.Multiline = true;
            this.txtUidProfileCT.Name = "txtUidProfileCT";
            this.txtUidProfileCT.Size = new System.Drawing.Size(315, 35);
            this.txtUidProfileCT.TabIndex = 2;
            this.txtUidProfileCT.TextChanged += new System.EventHandler(this.txtUidProfileCT_TextChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(162, 106);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 15);
            this.lbStatus.TabIndex = 4;
            // 
            // CloseProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCloseCT);
            this.Controls.Add(this.txtUidProfileCT);
            this.Name = "CloseProfile";
            this.Size = new System.Drawing.Size(400, 200);
            this.Load += new System.EventHandler(this.CloseProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseCT;
        private System.Windows.Forms.TextBox txtUidProfileCT;
        private System.Windows.Forms.Label lbStatus;
    }
}
