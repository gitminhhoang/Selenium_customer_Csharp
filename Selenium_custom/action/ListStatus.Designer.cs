namespace Selenium_custom.action
{
    partial class listStatus
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
            this.rtbListStatus = new System.Windows.Forms.RichTextBox();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbListStatus
            // 
            this.rtbListStatus.Location = new System.Drawing.Point(17, 59);
            this.rtbListStatus.Name = "rtbListStatus";
            this.rtbListStatus.Size = new System.Drawing.Size(541, 335);
            this.rtbListStatus.TabIndex = 0;
            this.rtbListStatus.Text = "";
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(17, 20);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(114, 23);
            this.btnGetStatus.TabIndex = 1;
            this.btnGetStatus.Text = "Get Status";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // listStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGetStatus);
            this.Controls.Add(this.rtbListStatus);
            this.Name = "listStatus";
            this.Size = new System.Drawing.Size(582, 411);
            this.Load += new System.EventHandler(this.ListStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListStatus;
        private System.Windows.Forms.Button btnGetStatus;
    }
}
