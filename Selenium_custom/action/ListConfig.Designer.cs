namespace Selenium_custom.action
{
    partial class ListConfig
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
            this.nbPage = new System.Windows.Forms.NumericUpDown();
            this.nbLimit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetList = new System.Windows.Forms.Button();
            this.rtbList = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // nbPage
            // 
            this.nbPage.Location = new System.Drawing.Point(12, 33);
            this.nbPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbPage.Name = "nbPage";
            this.nbPage.Size = new System.Drawing.Size(59, 20);
            this.nbPage.TabIndex = 1;
            this.nbPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nbLimit
            // 
            this.nbLimit.Location = new System.Drawing.Point(95, 33);
            this.nbLimit.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbLimit.Name = "nbLimit";
            this.nbLimit.Size = new System.Drawing.Size(60, 20);
            this.nbLimit.TabIndex = 2;
            this.nbLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Page:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limit:";
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(185, 30);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(96, 23);
            this.btnGetList.TabIndex = 5;
            this.btnGetList.Text = "Get list config";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // rtbList
            // 
            this.rtbList.Location = new System.Drawing.Point(12, 74);
            this.rtbList.Name = "rtbList";
            this.rtbList.Size = new System.Drawing.Size(564, 288);
            this.rtbList.TabIndex = 6;
            this.rtbList.Text = "";
            // 
            // ListConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbList);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbLimit);
            this.Controls.Add(this.nbPage);
            this.Name = "ListConfig";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.ListConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nbPage;
        private System.Windows.Forms.NumericUpDown nbLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.RichTextBox rtbList;
    }
}
