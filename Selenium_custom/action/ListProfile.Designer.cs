namespace Selenium_custom.action
{
    partial class ListProfile
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
            this.rtbList = new System.Windows.Forms.RichTextBox();
            this.btnGetListProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nbLimit = new System.Windows.Forms.NumericUpDown();
            this.nbPage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPage)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbList
            // 
            this.rtbList.Location = new System.Drawing.Point(16, 78);
            this.rtbList.Name = "rtbList";
            this.rtbList.Size = new System.Drawing.Size(564, 520);
            this.rtbList.TabIndex = 12;
            this.rtbList.Text = "";
            // 
            // btnGetListProfile
            // 
            this.btnGetListProfile.Location = new System.Drawing.Point(189, 34);
            this.btnGetListProfile.Name = "btnGetListProfile";
            this.btnGetListProfile.Size = new System.Drawing.Size(96, 23);
            this.btnGetListProfile.TabIndex = 11;
            this.btnGetListProfile.Text = "Get list profile";
            this.btnGetListProfile.UseVisualStyleBackColor = true;
            this.btnGetListProfile.Click += new System.EventHandler(this.btnGetListProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Limit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Page:";
            // 
            // nbLimit
            // 
            this.nbLimit.Location = new System.Drawing.Point(99, 37);
            this.nbLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbLimit.Name = "nbLimit";
            this.nbLimit.Size = new System.Drawing.Size(60, 20);
            this.nbLimit.TabIndex = 8;
            this.nbLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nbPage
            // 
            this.nbPage.Location = new System.Drawing.Point(16, 37);
            this.nbPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbPage.Name = "nbPage";
            this.nbPage.Size = new System.Drawing.Size(59, 20);
            this.nbPage.TabIndex = 7;
            this.nbPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ListProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbList);
            this.Controls.Add(this.btnGetListProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbLimit);
            this.Controls.Add(this.nbPage);
            this.Name = "ListProfile";
            this.Size = new System.Drawing.Size(604, 641);
            this.Load += new System.EventHandler(this.ListProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbList;
        private System.Windows.Forms.Button btnGetListProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbLimit;
        private System.Windows.Forms.NumericUpDown nbPage;
    }
}
